using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using KModkit;
using System;
using System.IO;


public class ASCIIArtScript : MonoBehaviour {

	public KMAudio audio;
	public KMBombInfo bomb;

	static int moduleIdCounter = 1;
	int moduleId;
	public bool moduleSolved = false;


	public KMSelectable numpad1;
	public KMSelectable numpad2;
	public KMSelectable numpad3;
	public KMSelectable numpad4;
	public KMSelectable numpad5;
	public KMSelectable numpad6;
	public KMSelectable numpad7;
	public KMSelectable numpad8;
	public KMSelectable numpad9;
	public KMSelectable numpad0;
	public KMSelectable numpadQuery;

	public Renderer numpadDisplay;


	public KMSelectable choix1;
	public KMSelectable choix2;
	public KMSelectable choix3;
	public KMSelectable choix4;

	public Font policeChange;
	public Material matChange;

	public Renderer row1,row2,row3,row4,row5,row6,row7,row8,row9,row10,row11,row12,row13,row14,row15,row16,row17,row18,row19,row20,row21,row22,row23,row24,row25;
	public Renderer[] rowarray;

	System.Random rand = new System.Random();

	public String[][][] files = {  
		//Category1
		new String[][] {
			//Text
			new String[]{ @"##    ##
##  ##
####
##  ##   °°°°°°°°°°
##    ## °°°°°°°°°°
##    ##     °°
             °°     
             °°    ++
             °°   ++++
             °°  ++  ++
                ++    ++    !!       !!
               ++++++++++   !!!!     !!
              ++        ++  !! !!    !!
             ++          ++ !!  !!   !!
                            !!   !!  !!  
                            !!    !! !!  #########
                            !!     !!!!  ##
                                         ##
                                         #########
                                         ##
                                         ##
                                         #########
                                                  
                                                  "},
			//Bomb
			new String[]{@"                                                 
                                                 
                                                 
                                 . +    `        
                                   +.!+.         
                                 + .! ! .        
                                    ##           
                                    #            
                  _###########_    ##            
               _#######+++#######_#.             
              ######:       ``!####              
            .###+`              !###.            
           .###`    .##          `###.           
           ###+   _###.           !###           
           ###    .#!             ####           
           !###                   ###+           
            !##!                !###+            
             !###.             !####+            
              `#####.__   __.#####`              
                `!#############+`                
                   ```+++++```                   
                                                 
                                                 
                                                 
                                                 "},
			//Food
			new String[]{ @"                          .°°.
                        °°°°°°°°
                       °°°°°°°°°°
                .#######°°°°°°++++=
               ###########°°++++++++
              #############++++++++++
              #############++++++++++
              !###########°°++++++++
               ###!######°°°°°°+!=
                ##!!!!!!!!!!!!!!!
                 ##!!!!!!!!!!!!!'
                 !#!!!!!!!!!!!!!
                  ##!!!!!!!!!!!'
                  ##!!!!!!!!!!!
                  ! `!!!!!!!!!'
                  .  !!!!!!!!!
                     `!!!!!!!'
                      !!!!!!!
                      `!!!!!'
                       !!!!!
                       `!!!'
                        !!!
                        `!'
"},
			//Object
			new String[]{ @"




          ###########################
          # #---------------------# #
          ###---------------------###
          ###---------------------###
          ###---------------------###
          ###---------------------###
          ###---------------------###
          ###########################
          #####++++++++++++++++######
          #####++#####+++++++++######
          #####++#####+++++++++######
          #####++#####+++++++++######
          #####++++++++++++++++######"},
			//Emote
			new String[]{@"
			


             _______________________
            #                       #
           #  __----___              #
          #        _+     _______     #
          #       !  !    +_  __+     #  
          #       +__!      !_!       #
          #                           #
          #                           #   
          #      !!++ _______         #
          #      !! !!        !       #
           #    !!  !!_________      #
            #__!!          ___ !!___#
              !!         !!
              !!         !!
              ++         !!
               ++########!!
           "},
			//Animal
			new String[]{ @"       ``°+_           __
        ``  `°++____,+°  `+
         #`+         !    ``+
         #  )       #      # `
          )++      ++ +#+`+;  #
         !##+++  +###+++   ` ;
         ; _ °    __        !#`
         `|_>   !`|_>      ;#+ `+
        `°`+__ ;   __--- !#+   `
        === `_!   ;=====_+°#+     ;
         ,_____      _____#        ;
              ;                    ;
            +°                      ;
          +°                        ;
        +°     ++     ,      +       ;
       #       ##++  !      ;##+     |
      !      `+;##+  |       ;#++    ;
     #         |#+   #       ;#+    ;
     #         ##     ;#++   |+    ;
      #       #;      ###++++|     |
      !`     ,! `      ;#####;     ;
    +#+ `#++|    #     ; °+°°|     ;
   ##+  #°°  `°+,,;     ;°   ;     ;
+°°+ _+°`      ! `;      `,__#      `
`----    `-----   ;      !    ------!"}
		},
		//Category2
		new String[][] {
			//Text
			new String[]{@"//    //
//  //
////
//  //   \\\\\\\\\\
//    // \\\\\\\\\\
//    //     \\
             \\     
             \\    __
             \\   ____
             \\  __  __
                __    __    ||       ||
               __________   ||||     ||
              __        __  || ||    ||
             __          __ ||  ||   ||
                            ||   ||  ||  
                            ||    || ||  /////////
                            ||     ||||  //
                                         //
                                         /////////
                                         //
                                         //
                                         /////////
                                                  
                                                  " },
			//Bomb
			new String[]{@"                                                 
                                                 
                                                 
                                 \   |   /       
                                  _ / \ _        
                                 -  \ /  -       
                                    / /          
                ___----------___    | |          
              //                 \\ / /          
             //                   \\ /           
            //   //                \\            
           //    //                 \\           
          //   //                    \\          
          ||                         ||          
          ||                         ||          
          \\                         //          
           \\                       //           
            \\                     //            
             \\                   //             
              \\___           ___//              
                   ----------                    
                                                 
                                                 
                                                 
                                                 "},
			//Food
			new String[]{ @"     




                          ___
                        / / //\
                       /// // /\
                      /// // //|
                     /// // ///
                    /// // ///
                   |_/_// ///
                     |_/_///
                    / /|_|/
                   / /   
                  / /
                 /_/  "},
			//Object
			new String[]{@"


           ---------------------------------            
          |__ --------------------------- __|           
          |__|                           |__|           
          |  |                           |  |           
          |  |                           |  |           
          |  |                           |  |           
          |  |                           |  |           
          |  |                           |  |           
          |  |                           |  |           
          |  |                           |  |           
          |  |                           |  |           
          |  `---------------------------'  |           
          |      __________________ _____   |           
          |     |   ___            |     |  |           
          |     |  |   |           |     |  |           
          |     |  |   |           |     |  |           
          |     |  |   |           |     |  |           
          |     |  |___|           |     |  |           
          \_____|__________________|_____|__|" },
			//Emote
			new String[]{@"      
			


             _______________________
            /                       \
           /  __----___              \
          |        _\     _______     |  
          |       |  |    \_  __\     |  
          |       \__/      |_|       |
          |                           |
          |                           |   
          |      ||\\ _______         |
          |      || ||        \       |
           \    //  ||_________      /
            \__//          ___ ||___/
              ||         ||
              ||         ||
              \\         ||
               \\________//
           " },
			//Animal
			new String[]{@"       \---_           __               
        \\  ----____---  --             
         |--         /    \--           
         |          |      | \          
          )--      -- -|---|  |         
         /||    |||---   - |          
         | _      __        /|\         
          \|_>    \|_>      ||  --       
         |  __     __-      /|-   \      
        === \_/   |=====_--|-     |     
         -__/ \___      _ /       |     
              |                    |    
            --                      |   
          --                        |   
        --     --     -      -       |  
       |       ||--  /      |||-     |  
      /      --|||-  |       ||--    |  
     |         ||-   |       ||-    |   
     |         ||     ||--   |-    |    
      |       ||      |||----|     |    
      /\     -/ \      |||||||     |    
    -|- \|--|    |     | ----|     |    
   ||-  |--  -----|     |-   |     |    
---- _--\      / -|      \-__|      \   
-----    ------   |      /    \-----/   " }
		},
		//Category3
		new String[][] {
			//Text
			new String[]{@"▓▓░░░▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
▓▓░░▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
▓▓░▓▓░░██████████░░░░░░░░░░░░░░░░░░░░░░░░
▓▓░░▓▓░██████████░░░░░░░░░░░░░░░░░░░░░░░░
▓▓░░░▓▓░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░██░░░█░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░██░░█░█░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░██░█░░░█░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░█░░░░░█░░░██░░░░░░██░░░░░░░░
░░░░░░░░░░░░█████████░░████░░░░██░░░░░░░░
░░░░░░░░░░░░█░░░░░░░█░░██░██░░░██░░░░░░░░
░░░░░░░░░░░█░░░░░░░░░█░██░░██░░██░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░██░░░██░██░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░██░░░░████░▓▓▓▓▓▓▓
░░░░░░░░░░░░░░░░░░░░░░░██░░░░████░▓▓░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" },
			//Bomb
			new String[]{ @"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░▓░░░░▒░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▒▓▓▒░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░▒▓░▓░▒░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█░░░░░░░░
░░░░░░░░░░░░░░▒███████████▒░░░░██░░░░░░░░
░░░░░░░░░░░▒███████▓▓▓███████▒█▒░░░░░░░░░
░░░░░░░░░░██████▒░░░░░░░▒▒▓████░░░░░░░░░░
░░░░░░░░▒███▓▒░░░░░░░░░░░░░░▓███▒░░░░░░░░
░░░░░░░▒███▒░░░░▒██░░░░░░░░░░▒███▒░░░░░░░
░░░░░░░███▓░░░▒███▒░░░░░░░░░░░▓███░░░░░░░
░░░░░░░███░░░░▒█▓░░░░░░░░░░░░░████░░░░░░░
░░░░░░░▓███░░░░░░░░░░░░░░░░░░░███▓░░░░░░░
░░░░░░░░▓██▓░░░░░░░░░░░░░░░░▓███▓░░░░░░░░
░░░░░░░░░▓███▒░░░░░░░░░░░░░▓████▓░░░░░░░░
░░░░░░░░░░▒█████▒▒▒░░░▒▒▒█████▒░░░░░░░░░░
░░░░░░░░░░░░▒▓█████████████▓▒░░░░░░░░░░░░
░░░░░░░░░░░░░░░▒▒▒▓▓▓▓▓▒▒▒░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░"},
			//Food
			new String[]{@"░░░░░░░░░░░░░░░░░░▓▓░
░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓
░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓
░░░░░░░░░███████▓▓▓▓▓▓▒▒▒▒░
░░░░░░░███████████▓▓▒▒▒▒▒▒▒▒
░░░░░░█████████████▒▒▒▒▒▒▒▒▒▒
░░░░░░█████████████▒▒▒▒▒▒▒▒▒▒
░░░░░▓███████████░░▒▒▒▒▒▒▒▒
░░░░░░███▓██████░░░░░░▒▓░
░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓░
░░░░░░░░▓█▓▓▓▓▓▓▓▓▓▓▓▓▓
░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓░
░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓
░░░░░░░░░▓░░▓▓▓▓▓▓▓▓▓░
░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓
░░░░░░░░░░░░░▓▓▓▓▓▓▓░
░░░░░░░░░░░░░▓▓▓▓▓▓▓
░░░░░░░░░░░░░░▓▓▓▓▓░
░░░░░░░░░░░░░░▓▓▓▓▓
░░░░░░░░░░░░░░░▓▓▓░
░░░░░░░░░░░░░░░▓▓▓
░░░░░░░░░░░░░░░░▓░" },
			//Object
			new String[]{@"




          ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
          ▓░▓░░░░░░░░░░░░░░░░░░░░░▓░▓
          ▓▓▓░░░░░░░░░░░░░░░░░░░░░▓▓▓
          ▓▓▓░░░░░░░░░░░░░░░░░░░░░▓▓▓
          ▓▓▓░░░░░░░░░░░░░░░░░░░░░▓▓▓
          ▓▓▓░░░░░░░░░░░░░░░░░░░░░▓▓▓
          ▓▓▓░░░░░░░░░░░░░░░░░░░░░▓▓▓
          ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
          ▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓
          ▓▓▓▓▓▒▒▓▓▓▓▓▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓
          ▓▓▓▓▓▒▒▓▓▓▓▓▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓
          ▓▓▓▓▓▒▒▓▓▓▓▓▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓
          ▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓" },
			//Emote
			new String[]{ @"
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░███████████████████████░░░░░
░░░░░░█░░░░░░░░░░░░░░░░░░░░░░░█░░░░
░░░░░█░░█████████░░░░░░░░░░░░░░█░░░
░░░░█░░░░░░░░██░░░░░███████░░░░░█░░
░░░░█░░░░░░░█░░█░░░░██░░███░░░░░█░░
░░░░█░░░░░░░████░░░░░░███░░░░░░░█░░
░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░█░░
░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░█░░
░░░░█░░░░░░████░███████░░░░░░░░░█░░
░░░░█░░░░░░██░██░░░░░░░░█░░░░░░░█░░
░░░░░█░░░░██░░███████████░░░░░░█░░░
░░░░░░█████░░░░░░░░░░███░██████░░░░
░░░░░░░░██░░░░░░░░░██░░░░░░░░░░░░░░
░░░░░░░░██░░░░░░░░░██░░░░░░░░░░░░░░
░░░░░░░░██░░░░░░░░░██░░░░░░░░░░░░░░
░░░░░░░░░████████████░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░"},
			//Animal
			new String[]{ @"       ▓░░░░░░░░░░░░░░░▓▓
        ▓▓░░▒▒▒▒░░░░▒▒▒░█▒▒
         █▒█░░░░░░░░░▓█░░░▓▒▒
         █░░▓░▓▓▓▓▓░█░░░░░░█░▓
          ▓▒▒█░░░░░▒▒░▒█▒▒▒█░░█
         ▓█░░░░░░░░░░░░░░░░░▒░█
         █░░░░█░░░░░░░█░░░░░░░█▓
         █░░░░░░░░░░░░░░░░░░░░░▒▒
        █░░░░░░░░░█░░░░░░░░░░░░░░▓
        ███░░░░░░█░█░░░░░░░░░░░░░█
         ▒██░░░░░░░░░░░░░░░░░░░░░░█
           ░██░░░░░░░░░░░░░░░░░░░░░█
            ▒▒░░░░░░░░░░░░░░░░░░░░░░█
          ▒▒░░░░░░░░░░░░░░░░░░░░░░░░█
        ▒▒░░░░░▒▒░░░░░▒░░░░░░▒░░░░░░░█
       █░░░░░░░██▒▒░░▓░░░░░░███▒░░░░░█
      ▓░░░░░░▒▒███▒░░█░░░░░░░██▒▒░░░░█
     █░░░░░░░░░██▒░░░█░░░░░░░██▒░░░░█
     █░░░░░░░░░██░░░░░██▒▒░░░█▒░░░░█
      █░░░░░░░██░░░░░░███▒▒▒▒█░░░░░█
      ▓▓░░░░░▒▓░▓░░░░░░███████░░░░░█
    ▒█▒░▓█▒▒█░░░░█░░░░░█░▒▒▒▒█░░░░░█
   ██▒░░█▒▒░░▒▒▒▒▒█░░░░░█▒░░░█░░░░░█
    ░▓▒▒▓░░░░░░▓░▒█░░░░░░▓▒▓▓█░░░░░░▓
  ████░░░░██████░░░███████▓░░░░▓████▓"}
		}  
	};

	//For which characters make up the image : 0 = #!().-_ , 1 = /\|-_ , 2 = ░▒▓█
	public int category;
	public int image;
	public int color;
	public Color[] colorList = {Color.white, Color.red, Color.yellow, Color.green, Color.cyan, Color.magenta}; 

	public String[] imageLines;

	public int[] numpadNb = new int[] { -1, -1, -1 };

	public int rule;

	public int[] ASCII;
	public int[][][] cube;
	public int[] PossibleAnswers;
	public int answer;
	public int[] displayAnswers = new int[4];




	void Awake(){
		moduleId = moduleIdCounter++;

		rowarray = new Renderer[25] {row1,row2,row3,row4,row5,row6,row7,row8,row9,row10,row11,row12,row13,row14,row15,row16,row17,row18,row19,row20,row21,row22,row23,row24,row25} ;



	}

	void Start () {

		ASCIIListConstructor ();
		PuzzleCreator ();
		AnswerFinder ();
		AnswerGenerator ();
		AnswerButtons ();

		int k = 1;
		int ans = 0;
		foreach (int i in displayAnswers) {
			Debug.LogFormat ("[Ascii Art #{0}] Button {1} : {2}",moduleId,k,i);
			if (i == ASCII [answer])
				ans = k;
			k++;

		}
		Debug.LogFormat ("[Ascii Art #{0}] The answer is button {1}",moduleId,ans);

		numpad1.OnInteract += delegate () {
			PressNumpad(1);
			return false;
		};
		numpad2.OnInteract += delegate () {
			PressNumpad(2);
			return false;
		};
		numpad3.OnInteract += delegate () {
			PressNumpad(3);
			return false;
		};
		numpad4.OnInteract += delegate () {
			PressNumpad(4);
			return false;
		};
		numpad5.OnInteract += delegate () {
			PressNumpad(5);
			return false;
		};
		numpad6.OnInteract += delegate () {
			PressNumpad(6);
			return false;
		};
		numpad7.OnInteract += delegate () {
			PressNumpad(7);
			return false;
		};
		numpad8.OnInteract += delegate () {
			PressNumpad(8);
			return false;
		};
		numpad9.OnInteract += delegate () {
			PressNumpad(9);
			return false;
		};
		numpad0.OnInteract += delegate () {
			PressNumpad(0);
			return false;
		};
		numpadQuery.OnInteract += delegate () {
			PressQuery();
			return false;
		};

		choix1.OnInteract += delegate () {
			PressAnswer(0);
			return false;
		};
		choix2.OnInteract += delegate () {
			PressAnswer(1);
			return false;
		};
		choix3.OnInteract += delegate () {
			PressAnswer(3);
			return false;
		};
		choix4.OnInteract += delegate () {
			PressAnswer(2);
			return false;
		};

	}

	void PuzzleCreator(){
		

		category = rand.Next (3);
		image = rand.Next (6);
		color = rand.Next (6);

		//Chooses 1 random element from the list of paths, and reads all lines
		//imageLines = System.IO.File.ReadAllLines(files[category][image][rand.Next(files[category][image].Length)]);
		imageLines = new String[25];

			using (var reader = new StringReader(files[category][image][rand.Next(files[category][image].Length)]))
			{
			int k = 0;
				for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
				{
					imageLines [k] = line;
					k++;
				}
			}


		//Display the image
		int j = 0;
		foreach(Renderer i in rowarray) {
			i.transform.GetComponent<TextMesh> ().text = imageLines[j];
			if(color==4)
				i.transform.GetComponent<TextMesh> ().color =  Color.cyan;
			else 
				i.transform.GetComponent<TextMesh> ().color =  colorList[color];

			j++;
		}

	}

	

	void RuleFinder(){
		if (bomb.GetBatteryCount () <= 0) {
			rule = 1;
		} else {
			if (bomb.GetPortPlateCount () > bomb.GetBatteryHolderCount ()) {
				rule = 2;
			} else {
				if (bomb.GetOnIndicators().Count() > bomb.GetOffIndicators().Count()) {
					rule = 3;
				} else { rule = 4; }
			}
		}
	}

	void AnswerFinder(){
		RuleFinder ();
		CubeConstructor ();
		Debug.LogFormat("[Ascii Art #{0}] The cube is at the coordinates {1},{2},{3} (image, color, characters)",moduleId,image,color,category);
		Debug.LogFormat("[Ascii Art #{0}] Rule n°{1}",moduleId,rule);
		Debug.LogFormat("[Ascii Art #{0}] The cube's number is : {1}",moduleId,FindNumber (image, color, category));
		FindAdjacent (image, color, category);
		Debug.LogFormat("[Ascii Art #{0}] Adjacent cubes : ",moduleId);
		foreach (int i in PossibleAnswers) {
			if (i != -1)
				Debug.LogFormat ("[Ascii Art #{0}] n°{1} -> ASCII conversion : {2} ",moduleId,i+1, ASCII[i] );
		}
		
		answer = -1;
		while (answer == -1) {
			answer = PossibleAnswers [rand.Next (PossibleAnswers.Length)];
		}
	}

	void PressNumpad(int nb){
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		InteractionPunchNumpad (nb);

		if (numpadNb [2] == -1) {
			numpadNb [2] = nb;
		} else {
			if (numpadNb [1] == -1) {
				numpadNb [1] = numpadNb [2];
				numpadNb [2] = nb;
			} else {
				if (numpadNb [0] == -1) {
					numpadNb [0] = numpadNb [1];
					numpadNb [1] = numpadNb [2];
					numpadNb [2] = nb;
				}
			}
		}

		DisplayNum (numpadNb);
	}

	void PressQuery(){
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		numpadQuery.AddInteractionPunch(.5f);
		int query = Convert (numpadNb);
		for (int i = 0; i < numpadNb.Length; i++) {
			numpadNb [i] = -1;
		}

		if (query >  108 || query <= 0) {
			DisplayNum (new int[] { 0, 0, 0 });
		} else {
			DisplayNum (Decompose(ASCII[query-1]));
		}
	}

	void PressAnswer(int nb){
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		InteractionPunchAnswer (nb);
		if (!moduleSolved) {
			Debug.LogFormat ("[Ascii Art #{0}] You pressed button {1}" ,moduleId,nb + 1);
			if (displayAnswers [nb] == ASCII [answer]) {
				//Solved
				GetComponent<KMBombModule> ().HandlePass ();
				moduleSolved = true;
			} else {
				//Strike
				GetComponent<KMBombModule> ().HandleStrike ();
			}
		}
	}

	void DisplayNum(int[] displayNb){
		String disp = "";
		for (int i = 0; i < displayNb.Length; i++) {
			if (displayNb [i] != -1)
				disp += displayNb [i];
			else
				disp += " ";
		}
		numpadDisplay.transform.GetComponent<TextMesh> ().text = disp;
	}

	int Convert(int[] nb){
		String resStr = "";
		for (int i = 0; i < nb.Length; i++) {
			if (nb [i] != -1)
				resStr += nb [i];
		}
		int res;
		int.TryParse (resStr, out res);
		return res;
	}

	int[] Decompose(int nb){
		int[] res = new int[3];
		int nbtemp = nb;
		res [2] = nbtemp % 10;
		nbtemp = nbtemp / 10;
		res [1] = nbtemp % 10;
		nbtemp = nbtemp / 10;
		res [0] = nbtemp % 10;
		return res;

	}

	void ASCIIListConstructor (){
		ASCII = new int[108];
		for (int i = 0; i < 95; i++) {
			ASCII [i] = 32 + i;
		}
		ASCII [95] = 130;
		ASCII [96] = 133;
		ASCII [97] = 138;
		ASCII [98] = 156;
		ASCII [99] = 167;
		ASCII [100] = 176;
		ASCII [101] = 177;
		ASCII [102] = 178;
		ASCII [103] = 219;
		ASCII [104] = 224;
		ASCII [105] = 225;
		ASCII [106] = 230;
		ASCII [107] = 253;


		//Shuffle

		int n = ASCII.Length;
		while (n > 1) 
		{
			int k = rand.Next(n--);
			int temp = ASCII[n];
			ASCII[n] = ASCII[k];
			ASCII[k] = temp;
		}
	}

	void CubeConstructor(){

		if (rule == 4) {
			cube = new int[][][] { 
				new int[][] { new int[] {6,27,18,4,14,2}, new int[]  {32+36,17+36,11+36,36+36,7+36,30+36}, new int[]  {34+72,22+72,5+72,25+72,15+72,29+72}, new int[] {33,20,12,19,13,3}, new int[]  {35+72,16+72,10+72,31+72,23+72,21+72},  new int[] {26+36,1+36,9+36,24+36,8+36,28+36}},
				new int[][] { new int[] {6+36,27+36,18+36,4+36,14+36,2+36}, new int[] {32,17,11,36,7,30}, new int[] {34+36,22+36,5+36,25+36,15+36,29+36}, new int[] {33+72,20+72,12+72,19+72,13+72,3+72}, new int[] {35,16,10,31,23,21}, new int[] {26+72,1+72,9+72,24+72,8+72,28+72}}, 
				new int[][] { new int[] {6+72,27+72,18+72,4+72,14+72,2+72}, new int[] {32+72,17+72,11+72,36+72,7+72,30+72}, new int[] {34,22,5,25,15,29}, new int[] {33+36,20+36,12+36,19+36,13+36,3+36}, new int[] {35+36,16+36,10+36,31+36,23+36,21+36}, new int[] {26,1,9,24,8,28}}} ;
		} else {
			cube = new int[3][][];
			for (int face = 0; face < 3; face++) {
				cube [face] = new int[6][];
				for (int row = 0; row < 6; row++) {
					cube [face] [row] = new int[6];
				}
			}

			if (rule == 1) {
				int i = 1;
				for (int face = 0; face < 3; face++) {
					for (int row = 0; row < 6; row++) {
						for (int cell = 0; cell < 6; cell++) {
							cube [face] [row] [cell] = i;
							i++;
						}
					}
				}
			}
			if (rule == 2) {
				int i = 108;
				for (int face = 0; face < 3; face++) {
					for (int row = 0; row < 6; row++) {
						for (int cell = 0; cell < 6; cell++) {
							cube [face] [row] [cell] = i;
							i--;
						}
					}
				}
			}
			if (rule == 3) {
				int i = 1;
				for (int face = 0; face < 3; face++) {
					for (int row = 0; row < 12; row++) {
						for (int cell = 0; cell <= row; cell++) {
							if (cell < 6 && row - cell < 6) {
								cube [face] [cell] [row - cell] = i;
								i++;
								//Debug.Log ("coord (" + cell + "," + (row - cell) + ") i=" + i);
							}
						}

					}
				}
			}
		}

	}

	void FindAdjacent(int image, int color, int category){
		PossibleAnswers = new int[] { -1, -1, -1, -1, -1, -1 };
		if (image != 0) {
			PossibleAnswers [0] = FindNumber (image - 1, color, category) -1;
		}
		if (image != 5) {
			PossibleAnswers [1] = FindNumber (image + 1, color, category) -1;
		}
		if (color != 0) {
			PossibleAnswers [2] = FindNumber (image, color -1, category) -1;
		}
		if (color != 5) {
			PossibleAnswers [3] = FindNumber (image, color +1, category) -1;
		}
		if (category != 0) {
			PossibleAnswers [4] = FindNumber (image, color, category -1) -1;
		}
		if (category != 2) {
			PossibleAnswers [5] = FindNumber (image, color, category+1) -1;
		}
	}

	int FindNumber(int image, int color, int category){
		return cube [category] [image] [color];
	}

	void AnswerGenerator(){
		bool ok = false;
		while (!ok) { 
			for (int i = 0; i < 4; i++) {
				displayAnswers [i] = ASCII [rand.Next (ASCII.Length)];
			}
			//Check if the random hasn't selected the answer
			ok = true;
			for (int i = 0; i < 4; i++) {
				if (displayAnswers [i] == answer)
					ok = false;
			}
			//To lazy to check if all values are distinct, if anyone wants to do it be my guest
		}

		displayAnswers [rand.Next (displayAnswers.Length)] = ASCII[ answer ];
	}

	void AnswerButtons(){
		if (displayAnswers [0] < 127) {
			choix1.transform.GetChild (1).GetComponent<TextMesh> ().text = ((char)displayAnswers [0]).ToString();
		} else {
			choix1.transform.GetChild (1).GetComponent<TextMesh> ().text = ConvertASCII(displayAnswers [0]).ToString();
		}
		if (displayAnswers [1] < 127) {
			choix2.transform.GetChild (1).GetComponent<TextMesh> ().text = ((char)displayAnswers [1]).ToString();
		}else {
			choix2.transform.GetChild (1).GetComponent<TextMesh> ().text = ConvertASCII(displayAnswers [1]).ToString();
		}
		if (displayAnswers [2] < 127) {
			choix3.transform.GetChild (1).GetComponent<TextMesh> ().text = ((char)displayAnswers [2]).ToString();
		}else {
			choix3.transform.GetChild (1).GetComponent<TextMesh> ().text = ConvertASCII(displayAnswers [2]).ToString();
		}
		if (displayAnswers [3] < 127) {
			choix4.transform.GetChild (1).GetComponent<TextMesh> ().text = ((char)displayAnswers [3]).ToString();
		}else {
			choix4.transform.GetChild (1).GetComponent<TextMesh> ().text = ConvertASCII(displayAnswers [3]).ToString();
		}
	}

	char ConvertASCII(int nb){
		//Because apparently, ASCII values in C# aren't the same as the consensus for the extended table
		switch (nb) {
		case 130:
			return 'é';
		case 133:
			return 'à';
		case 138:
			return 'è';
		case 156:
			return '£';
		case 167:
			return '°';
		case 176:
			return '░';
		case 177:
			return '▒';
		case 178:
			return '▓';
		case 219:
			return '█';
		case 224:
			return 'α';
		case 225:
			return 'β';
		case 230:
			return 'µ';
		case 253:
			return '²';
		default:
			return ' ';
		}
	}

	void InteractionPunchNumpad (int nb){
		switch (nb) {
		case 1:
			numpad1.AddInteractionPunch (.5f);
			break;
		case 2:
			numpad2.AddInteractionPunch (.5f);
			break;
		case 3:
			numpad3.AddInteractionPunch (.5f);
			break;
		case 4:
			numpad4.AddInteractionPunch (.5f);
			break;
		case 5:
			numpad5.AddInteractionPunch (.5f);
			break;
		case 6:
			numpad6.AddInteractionPunch (.5f);
			break;
		case 7:
			numpad7.AddInteractionPunch (.5f);
			break;
		case 8:
			numpad8.AddInteractionPunch (.5f);
			break;
		case 9:
			numpad9.AddInteractionPunch (.5f);
			break;
		case 0:
			numpad0.AddInteractionPunch (.5f);
			break;
		}
	}

	void InteractionPunchAnswer (int nb){
		switch (nb) {
		case 0:
			choix1.AddInteractionPunch (1f);
			break;
		case 1:
			choix2.AddInteractionPunch (1f);
			break;
		case 3:
			choix3.AddInteractionPunch (1f);
			break;
		case 2:
			choix4.AddInteractionPunch (1f);
			break;
		}
	}

	string TwitchHelpMessage = "Use '!{0} query 42' to query that number. Use '!{0} submit <topleft|topright|bottomleft|bottomright> to submit that button. You can also use <tl|tr|bl|br>.";

	IEnumerator ProcessTwitchCommand(string command)
	{
		if (command.Equals("submit topleft", StringComparison.InvariantCultureIgnoreCase) || command.Equals("submit tl", StringComparison.InvariantCultureIgnoreCase)) {
			yield return null;
			choix1.OnInteract();
		}
		if (command.Equals("submit topright", StringComparison.InvariantCultureIgnoreCase) || command.Equals("submit tr", StringComparison.InvariantCultureIgnoreCase)) {
			yield return null;
			choix2.OnInteract();
		}
		if (command.Equals("submit bottomleft", StringComparison.InvariantCultureIgnoreCase) || command.Equals("submit bl", StringComparison.InvariantCultureIgnoreCase)) {
			yield return null;
			choix4.OnInteract();
		}
		if (command.Equals("submit bottomright", StringComparison.InvariantCultureIgnoreCase) || command.Equals("submit br", StringComparison.InvariantCultureIgnoreCase)) {
			yield return null;
			choix3.OnInteract();
		}

		var parts = command.ToLowerInvariant().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		Int32 tryparse;
		if (parts.Length != 2) yield break;
		else if (parts [0].Equals ("query", StringComparison.InvariantCultureIgnoreCase) && int.TryParse(parts [1].ToString(),out tryparse)) 
		{
			char[] query = parts [1].ToCharArray ();
			yield return null;
			foreach (char c in query) 
			{
				int use = int.Parse (c.ToString());
				switch (use)
				{
					case 0: numpad0.OnInteract(); break;
					case 1: numpad1.OnInteract(); break;
					case 2: numpad2.OnInteract(); break;
					case 3: numpad3.OnInteract(); break;
					case 4: numpad4.OnInteract(); break;
					case 5: numpad5.OnInteract(); break;
					case 6: numpad6.OnInteract(); break;
					case 7: numpad7.OnInteract(); break;
					case 8: numpad8.OnInteract(); break;
					case 9: numpad9.OnInteract(); break;
				}
			}
			numpadQuery.OnInteract();
		}
	}
}
