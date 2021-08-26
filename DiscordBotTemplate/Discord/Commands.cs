using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotTemplate.Discord
{
    public class Commands : BaseCommandModule
    {
        [Command("penis")]
        [Aliases("chicken", "peen")]
        [Description("Command Description")]
        [Cooldown(1, 3, CooldownBucketType.User)]
        public async Task PenisCommand(CommandContext bot)
        {
            // Make it show the bot looks like it's typing something
            await bot.TriggerTypingAsync();

            // Respond to who ever called the command
            await bot.RespondAsync("Yessur");

            // Create an embed
            var embed = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Goldenrod,
                Title = $"Title PogU",
                Description = $"This is the embed Description. YAY!\n‎"
            };

            // Add Embed Info
            embed.AddField($"Field One", $"Hello, {bot.Member.DisplayName}\n‎", false);
            embed.AddField($"Field Two", $"More stuff!\n‎", false);
            embed.WithFooter("Lyod", "https://i.imgur.com/Q0xNEmg.png");

            // Send the embeded message.
            await bot.RespondAsync(embed);

        }
    }
}
