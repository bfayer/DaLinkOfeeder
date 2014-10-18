using System;
using System.Collections.Generic;
using System.Text;
using Terraria;
using TAPI;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;


namespace TAPI.DaLinkOfeeder {
    sealed class MPlayer : ModPlayer
    {
				DR b = new DR();
        PipeClient myPipeClient = new PipeClient();
        string source;
		

        



        
        // public override void OnUpdate() {
		////commented out for now, wasn't providing any benefit
		
		// base.OnUpdate();
		// b.dataPacks[0].dataElement[0].V = Convert.ToString(player.statLife);
		// b.dataPacks[0].dataElement[1].V = Convert.ToString(player.statLifeMax);
		// b.dataPacks[0].dataElement[2].V = Convert.ToString(player.statMana);
		// b.dataPacks[0].dataElement[3].V = Convert.ToString(player.statManaMax);

		
		// Thread myThread = new Thread(myPipeClient.Transmit);
        // myThread.Start(b);
        // }
				
		public override void Load(BinBuffer bb)
        {
            base.Load(bb);
					
					source = "Terraria";
					b.dataPacks.Add(new DP());
			
            
					b.dataPacks[0].Src = source; 
					b.dataPacks[0].v = "0.01";
					b.TV = "1.00";
					b.dataPacks[0].dataElement.Add(new DE("Current HP", player.statLife.GetType().ToString(), player.statLife.ToString() ));  // 0
					b.dataPacks[0].dataElement.Add(new DE("Max HP", player.statLifeMax.GetType().ToString(), player.statLifeMax.ToString() )); // 1
					b.dataPacks[0].dataElement.Add(new DE("Current Mana", player.statMana.GetType().ToString(), player.statMana.ToString() ));  //2
					b.dataPacks[0].dataElement.Add(new DE("Max Mana", player.statManaMax.GetType().ToString(), player.statManaMax.ToString() )); //3
					b.dataPacks[0].dataElement.Add(new DE("Breath", player.breath.GetType().ToString(), player.breath.ToString() )); //4
					b.dataPacks[0].dataElement.Add(new DE("Max Breath", player.breathMax.GetType().ToString(), player.breathMax.ToString() )); //5
					b.dataPacks[0].dataElement.Add(new DE("Dead", player.dead.GetType().ToString(), player.dead.ToString() )); //6
					//b.dataPacks[0].dataElement.Add(new DE("Power Run", player.powerrun.GetType().ToString(), player.powerrun.ToString() )); //7

					
					/*
					player.suffocating = false;
					player.slippy = false;
					player.slippy2 = false;
					player.powerrun = false;
					player.poisoned = false;
					player.venom = false;
					player.onFire = false;
					player.onFire2 = false;
					player.ichor = false;
					player.blackout = false;
					player.burned = false;
					player.onFrostBurn = false;
					player.blind = false;
					player.immune = true;
					player.lavaImmune = true;
					player.noKnockback = true;
					*/
							
					
					//b.dataPacks[0].dataElement.Add(new DE("suffocating", player.suffocating.GetType().ToString(), player.suffocating.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("slippy", player.slippy.GetType().ToString(), player.slippy.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("slippy2", player.slippy2.GetType().ToString(), player.slippy2.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("powerrun", player.powerrun.GetType().ToString(), player.powerrun.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("poisoned", player.poisoned.GetType().ToString(), player.poisoned.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("venom", player.venom.GetType().ToString(), player.venom.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("onFire", player.onFire.GetType().ToString(), player.onFire.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("onFire2", player.onFire2.GetType().ToString(), player.onFire2.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("ichor", player.ichor.GetType().ToString(), player.ichor.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("blackout", player.blackout.GetType().ToString(), player.blackout.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("burned", player.burned.GetType().ToString(), player.burned.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("onFrostBurn", player.onFrostBurn.GetType().ToString(), player.onFrostBurn.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("blind", player.blind.GetType().ToString(), player.blind.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("immune", player.immune.GetType().ToString(), player.immune.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("lavaImmune", player.lavaImmune.GetType().ToString(), player.lavaImmune.ToString() ));
					// b.dataPacks[0].dataElement.Add(new DE("noKnockback", player.noKnockback.GetType().ToString(), player.noKnockback.ToString() ));



        }	

		
		public override void PostUpdate()
        {
			base.PostUpdate();

			if (player == Main.localPlayer)
				{}
				
				
				try{

					b.dataPacks[0].dataElement[0].V = Convert.ToString(player.statLife);
					b.dataPacks[0].dataElement[1].V = Convert.ToString(player.statLifeMax);
					b.dataPacks[0].dataElement[2].V = Convert.ToString(player.statMana);
					b.dataPacks[0].dataElement[3].V = Convert.ToString(player.statManaMax);						
					b.dataPacks[0].dataElement[4].V = Convert.ToString(player.breath);
					b.dataPacks[0].dataElement[5].V = Convert.ToString(player.breathMax);
					b.dataPacks[0].dataElement[6].V = Convert.ToString(player.dead);
					//b.dataPacks[0].dataElement[7].V = Convert.ToString(player.powerrun);

						/*
					player.suffocating = false;
                    player.slippy = false;
                    player.slippy2 = false;
                    player.powerrun = false;
                    player.poisoned = false;
                    player.venom = false;
                    player.onFire = false;
                    player.onFire2 = false;
                    player.ichor = false;
                    player.blackout = false;
                    player.burned = false;
                    player.onFrostBurn = false;
                    player.blind = false;
                    player.immune = true;
                    player.lavaImmune = true;
                    player.noKnockback = true;
					*/
					
					
					// b.dataPacks[0].dataElement[4].V = Convert.ToString(player.suffocating);
					// b.dataPacks[0].dataElement[5].V = Convert.ToString(player.slippy);
					// b.dataPacks[0].dataElement[6].V = Convert.ToString(player.slippy2);
					// b.dataPacks[0].dataElement[7].V = Convert.ToString(player.powerrun);
					// b.dataPacks[0].dataElement[8].V = Convert.ToString(player.poisoned);
					// b.dataPacks[0].dataElement[9].V = Convert.ToString(player.venom);
					// b.dataPacks[0].dataElement[10].V = Convert.ToString(player.onFire);
					// b.dataPacks[0].dataElement[11].V = Convert.ToString(player.onFire2);
					// b.dataPacks[0].dataElement[12].V = Convert.ToString(player.ichor);
					// b.dataPacks[0].dataElement[13].V = Convert.ToString(player.blackout);
					// b.dataPacks[0].dataElement[14].V = Convert.ToString(player.burned);
					// b.dataPacks[0].dataElement[15].V = Convert.ToString(player.onFrostBurn);
					// b.dataPacks[0].dataElement[16].V = Convert.ToString(player.blind);
					// b.dataPacks[0].dataElement[17].V = Convert.ToString(player.immune);
					// b.dataPacks[0].dataElement[18].V = Convert.ToString(player.lavaImmune);
					// b.dataPacks[0].dataElement[19].V = Convert.ToString(player.noKnockback);
					
				}
				catch{}
			
			Thread myThread = new Thread(myPipeClient.Transmit);
			myThread.Start(b);
			
		}
		
				
    }
}
