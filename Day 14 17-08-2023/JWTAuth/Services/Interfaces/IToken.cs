namespace JWTAuth.Services.Interfaces
{
    public interface IToken
    {

        string GenerateToken(string username, string role);
    }
}
