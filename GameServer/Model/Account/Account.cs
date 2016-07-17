﻿namespace GameServer.Model.Account
{
    /// <summary>
    /// Account Model Class
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Account ID
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Account Name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Account Password
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Account Level
        /// </summary>
        public virtual AccountLevel AccountLevel { get; set; }

        /// <summary>
        /// Account Token
        /// </summary>
        public virtual string Token { get; set; }
    }
}