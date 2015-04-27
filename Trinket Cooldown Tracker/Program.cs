﻿using System;
using System.Collections;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Collections.Generic;
using System.Threading;

namespace Trinket_Cooldown_Tracker
{
  class Program
  {

    private static Menu Config;

    public static Items.Item Warding Totem = new Items.Item(3340, 600f);
    
    public static Items.Item Greater Stealth Totem = new Items.Item(3361, 600f);
    
    public static Items.Item Greater Vision Totem = new Items.Item(3362, 600f);
    
    public static Items.Item Sweeping Lens = new Items.Item(3341, 600f);
    
    public static Items.Item Oracles Lens = new Items.Item(3364, 600f);
    
    public static Items.Item Scrying Orb = new Items.Item(3342, 600f);
    
    public static Items.Item Farsight Orb = new Items.Item(3363, 600f);

    public static Obj_AI_Hero Player
    {
      get
      {
        return ObjectManager.Player;
      }
    }
    static void Main(string[] args)
    {
      CustomEvents.Game.OnGameLoad += OnGameLoad;
      Drawing.OnDraw += OnDraw;
    }

    private static void OnGameLoad(EventArgs args)
    {
      Game.PrintChat("Trinket Tracker by DanZ and Drunkenninja loaded");
      Config = new Menu("Trinket Tracker", "Trinket_Tracker", true);
      Config.AddSubMenu(new Menu("On", "On"));
      Config.SubMenu("On").AddItem(new MenuItem("On", "On")).SetValue(true);

      Config.AddToMainMenu();
      Game.OnUpdate += OnGameUpdate;

    }


    private static void OnDraw(EventArgs args)
    {
    }

    private static void OnGameUpdate(EventArgs args)
    {

      if (Config.Item("On").GetValue<bool>())
      {
        if (Trinket.IsOwned())
        {
          if (Trinket.IsReady())
          {

            Drawing.DrawText(Player.HPBarPosition.X +30, Player.HPBarPosition.Y - 30, Color.LawnGreen, "Trinket Up!");
          }
          else
          {
            Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.Red, "Trinket Down!");

          }
        }
      }
    }
  }
}
