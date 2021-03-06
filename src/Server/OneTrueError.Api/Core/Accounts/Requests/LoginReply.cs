﻿namespace OneTrueError.Api.Core.Accounts.Requests
{
    /// <summary>
    ///     Reply for <see cref="Login" />.
    /// </summary>
    public class LoginReply
    {
        /// <summary>
        ///     Account id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        ///     Login result
        /// </summary>
        public LoginResult Result { get; set; }

        /// <summary>
        ///     User name
        /// </summary>
        public string UserName { get; set; }
    }
}