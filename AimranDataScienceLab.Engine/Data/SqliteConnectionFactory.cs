using Microsoft.Data.Sqlite;

namespace AimranDataScienceLab.Engine.Data;

/// <summary>
/// Creates and manages SQLite connections for the AIMRAN metadata database.
/// </summary>
public sealed class SqliteConnectionFactory : IDisposable
{
    private readonly string _connectionString;
    private bool _disposed;

    public SqliteConnectionFactory(string? databasePath = null)
    {
        var dbPath = databasePath ?? Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "AIMRAN-DataScience",
            "aimran.db");

        var dbDir = Path.GetDirectoryName(dbPath);
        if (!string.IsNullOrEmpty(dbDir))
        {
            Directory.CreateDirectory(dbDir);
        }

        _connectionString = new SqliteConnectionStringBuilder
        {
            DataSource = dbPath,
            Mode = SqliteOpenMode.ReadWriteCreate,
            Cache = SqliteCacheMode.Shared
        }.ToString();

        DatabasePath = dbPath;
    }

    /// <summary>
    /// The full path to the SQLite database file.
    /// </summary>
    public string DatabasePath { get; }

    /// <summary>
    /// Create a new open connection.
    /// </summary>
    public SqliteConnection CreateConnection()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        var connection = new SqliteConnection(_connectionString);
        connection.Open();

        // Enable WAL mode for better concurrent read performance
        using var cmd = connection.CreateCommand();
        cmd.CommandText = "PRAGMA journal_mode=WAL; PRAGMA foreign_keys=ON;";
        cmd.ExecuteNonQuery();

        return connection;
    }

    public void Dispose()
    {
        _disposed = true;
    }
}
