namespace Leashar.Domain.Common.Options;

public class DatabaseOptions
{
    public string ConnectionString { get; set; } = default!;
    public string Host { get; set; } = default!;
    public string User { get; set; } = default!;
    public int Port { get; set; }
    public string Password { get; set; } = default!;
    public string Database { get; set; } = default!;
    public string SslMode { get; set; } = default!;
}