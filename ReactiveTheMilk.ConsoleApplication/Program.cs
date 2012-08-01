using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Diagnostics;

namespace ReactiveTheMilk.ConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string apiKey = "91d9ca5f94e7a83d7fcf9a6e0190191d";
      string secret = "089415a5eeac8576";
      var rtmAuthorizer = new RtmAuthorizer(apiKey, secret);

      string frob = rtmAuthorizer.GetFrob().First();

      string authenticationUrl = rtmAuthorizer.GetAuthenticationUrl(frob);

      //Process.Start(authenticationUrl);

      //Console.WriteLine("Webページで認証してください。...");

      //Console.ReadKey();

      //var token = rtmAuthorizer.GetToken(frob).First();

      //Console.WriteLine("Token:{0}", token.Token);

      RtmClient client = new RtmClient(apiKey, secret, "d0b897aaf58e530b52f49c15db9ff89c1679b6e9");

      var lists = client.GetLists();

      var list = lists.First();

    }
  }
}
