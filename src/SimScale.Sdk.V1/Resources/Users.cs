using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Users
{
    private readonly SimScaleClient _client;

    public Users(SimScaleClient client) => _client = client;

    /// <summary>Get information about the currently authenticated user Get information about the currently authenticated user, such as name and email.</summary>
    public User GetCurrentUser()
    {
        return _client.Request<User>(HttpMethod.Get, $"/users/me");
    }

    /// <summary>Signup a user Signup a new user. The current requester user needs to be authenticated.</summary>
    public UserSignupResponse SignupUser(
        UserSignupRequest body
    )
    {
        return _client.Request<UserSignupResponse>(HttpMethod.Post, $"/users", body);
    }
}
