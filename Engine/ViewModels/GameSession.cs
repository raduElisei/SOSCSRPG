using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Bob";
            CurrentPlayer.HitPoints = 25;
            CurrentPlayer.Level = 1;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Gold = 0;
            CurrentPlayer.ExperiencePoints = 0;
        }
    }
}