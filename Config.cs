using System;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace mysite.auth
{
    public static class Config{

        public static IEnumerable<ApiResource> GetApiResources(){
            return new List<ApiResource> {
                new ApiResource("api1", "My API")
            };
        }

        public static IEnumerable<Client> GetClients(){
            return new List<Client> {
                new Client(){
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets = 
                    {
                        new Secret("secert".Sha256())
                    },
                    AllowedScopes = {"api1"}
                }
            };
        }

        public static IEnumerable<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "Bryan",
                    Password = "BryansPassword"
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "Bryan2",
                    Password = "BryansPassword2"
                }
            };
        }
    }
}