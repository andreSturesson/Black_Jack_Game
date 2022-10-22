using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Player
    {
        private Hand hand;
        private bool isFinished;
        private string Name;
        private Guid id;
        private bool isWinner;

        public Player(Guid id, string name)
        {
            this.hand = new Hand();
            this.isFinished = false;
            Name = name;
            this.id = id;
            this.isWinner = false;
        }

        public Hand Hand { get => hand; set => hand = value; }
        public bool IsFinished { get => isFinished; set => isFinished = value; }
        public string Name1 { get => Name; set => Name = value; }
        public Guid Id { get => id; }
        public bool IsWinner { get => isWinner; set => isWinner = value; }

    }
}
