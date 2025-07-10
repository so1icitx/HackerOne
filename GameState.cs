using System;
using System.Collections.Generic;

namespace BlueTeamerRole
{
    public static class GameState
    {
        public static double Monero = 0.0;
        public static string WalletAddress = "4AdkWjX8pL2z3qN7mQvT5xY6ZcK9rF1uG2h3jK4mN5pQ6rS7tU8vW9xY0zA1bC2dE3fG4hJ5kL6mN7pQ8rS9tU0vW1xY2z";
        public static List<string> PurchasedItems = new List<string>();
        public static double RaidChanceReduction = 0.0;
        public static double BaseRaidChance = 0.02;
        public static double MoneroPerHack = 2.0;
        public static string CurrentMalware = "Phishing Email";
        public static double MiningRate = 2.0;
        public static int DrugEffectHacksLeft = 0;
        public static string PlayerName = "";
    }
}