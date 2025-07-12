using System;
using System.Collections.Generic;

namespace BlueTeamerRole
{
    public static class GameState
    {
        public static double Monero = 150.0;
        public static string WalletAddress = "4AdkWjX8pL2z3qN7mQvT5xY6ZcK9rF1uG2h3jK4m";
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