using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotTemplate.Discord
{
    class Main
    {
        private DiscordClient Client;
        private CommandsNextExtension Command;

        // Command Prefix
        private string[] Prefix = { "!", "L!" };

        private Task BotThread { get; set; }

        public Main()
        {
            // Setup bot
            Client = new DiscordClient(new DiscordConfiguration
            {
                Token = "",
                TokenType = TokenType.Bot,
                AutoReconnect = true,

                //  Set Bots Intentions
                //  More info @ https:// dsharpplus.github.io/articles/beyond_basics/intents.html
                Intents = DiscordIntents.AllUnprivileged

            });

            // Setup CommandNext
            Command = Client.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefixes = Prefix,
                EnableDms = false,
                EnableMentionPrefix = true,
                IgnoreExtraArguments = true,
                CaseSensitive = false
            });

            // Set a MessageCreate Event and move it to Message_Created
            Client.MessageCreated += Message_Created;

            // Set the Commands blah blah and link it to Discord.Commands
            Command.RegisterCommands<Discord.Commands>();

            // Connect to bot
            this.BotThread = Task.Run(BotThreadCallback);

            // Connected :)
            Bot.UI.CenterStatusText("Connected");
        }

        public Task StartAsync()
            => Client.ConnectAsync();

        public async Task BotThreadCallback()
            => await StartAsync().ConfigureAwait(false);

        // Fire up whenever a message is created and do something
        public async Task Message_Created(DiscordClient sender, MessageCreateEventArgs e)
        {
            // Check if user is a bot and skip if is
            if (e.Author.IsBot)
                return;

            // Log in Console
            Console.WriteLine($"{e.Author.Username} said '{e.Message.Content}' @ {e.Channel.Name}");

            // React to all new Messages with an :ok_hand: emoji
            await e.Message.CreateReactionAsync(DiscordEmoji.FromName(Client, ":ok_hand:"));
        }
    }
}
