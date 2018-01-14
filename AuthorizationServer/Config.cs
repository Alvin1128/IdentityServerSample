using System.Collections;
using System.Collections.Generic;
using IdentityServer4.Models;

namespace AuthorizationServer
{

    public class Config
    {
        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource>{
                new ApiResource("api","My Api")
            };
        }


        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>{
                new Client(){
                    ClientId="client1",
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    AllowedScopes={"api"},
                    ClientSecrets= new List<Secret>(){
                        new Secret("123456".Sha256())
                    }
                }
            };
        }
    }


}