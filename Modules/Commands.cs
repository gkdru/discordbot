using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.API;

namespace DISCORD_BOT.Modules
{

    public class Commands : ModuleBase<SocketCommandContext>
    {
        public int hp1 = 1000;
        public int hp2 = 1000;



        [Command("Play")]


        public async Task Play()
        {








            Random random = new Random();
            await ReplyAsync("Игрок2 выберите чем хотите ударить Игрока1 ");
            await ReplyAsync("Рукой");
            await ReplyAsync("Бутылкой");
            await ReplyAsync("Черпахой");
            await ReplyAsync("Камнем");


        }


        [Command("Рукой")]


        public async Task Рукой()

        {
            int a;
            int b;

            Random random = new Random();
            a = random.Next(1, 10);
            b = random.Next(1, 300);
            int c = random.Next(1, 2);

            if (c == 1)
            {
                int hp3 = 1000;
                hp2 = hp3 - b;
                await ReplyAsync($"Вы попали и нанесли {b} урона");
                await ReplyAsync($"У игрока2 осталось{hp2}хп");
            }



            else
            {
                await ReplyAsync("Вы промахнулись");
            }


            await ReplyAsync("Игрок2 выберите чем хотите ударить Игрока1 ");
            await ReplyAsync("Левой рукой");
            await ReplyAsync("Бутылкой");
            await ReplyAsync("Черпахой");
            await ReplyAsync("Камнем");
        }

        [Command("Бутылкой")]


        public async Task Бутылкой()
        {
            int a;
            int b;

            Random random = new Random();
            a = random.Next(1, 10);
            b = random.Next(1, 450);
            int c = random.Next(1, 2);

            if (c == 1)
            {
                int hp3 = 1000;
                hp1 = hp3 - b;
                await ReplyAsync($"Вы попали и нанесли {b} урона");
                await ReplyAsync($"У игрока1 осталось{hp1}хп");


                await ReplyAsync("Игрок1 выберите чем хотите ударить Игрока2 ");
                await ReplyAsync("Левой рукой");
                await ReplyAsync("Бутылкой");
                await ReplyAsync("Черпахой");
                await ReplyAsync("Камнем");
            }


        }

    }
 





    }

