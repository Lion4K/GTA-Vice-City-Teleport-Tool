�TP_TL_7   �  V M ����  �  �gM ����d  ����  �  �7M ���� �����     �      ���� dU      ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �  {$CLEO .cs}

script_name 'TP_TL_7' 

:START
wait 0 
if 
  Player.Defined($PLAYER_CHAR)
jf @START 

:KP_SV_7
wait 0 
if 
05EE:   key_pressed 103
jf @KP_TP_7 
0164: 4@
jump @ST_TP_7 

:KP_TP_7
wait 0 
if 
05EE:   key_pressed 55 
jf @KP_SV_7 
jump @GO_TP_7

:ST_TP_7
Actor.StorePos($PLAYER_ACTOR, 1@, 2@, 3@)
02A8: 4@ = create_marker 0 at 1@ 2@ 3@ 
jump @START 

:GO_TP_7
wait 100 
0055: put_player $PLAYER_CHAR at 1@ 2@ 3@ 
jump @START�   __SBFTR 