using System;
using System.Collections.Generic;

namespace BlueTeamerRole
{
    public class GameState
    {
        public double Monero { get; set; } = 50.0;
        public string WalletAddress { get; } = "4AdkWjX8pL2z3qN7mQvT5xY6ZcK9rF1uG2h3jK4mN5pQ6rS7tU8vW9xY0zA1bC2dE3fG4hJ5kL6mN7pQ8rS9tU0vW1xY2z";
        public List<string> PurchasedItems { get; set; } = new List<string>();
        public double RaidChanceReduction { get; set; } = 0.0;
        public double BaseRaidChance { get; set; } = 0.02;
        public double MoneroPerHack { get; set; } = 2.0;
        public string CurrentMalware { get; set; } = "Phishing Email";
        public double MiningRate { get; set; } = 2.0;
        public int DrugEffectHacksLeft { get; set; } = 0;
    }
}