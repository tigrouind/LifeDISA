﻿using System;

namespace LifeDISA
{
	public enum LifeEnum
	{
		DO_MOVE,
		ANIM_ONCE,
		ANIM_ALL_ONCE,
		BODY,
		IF_EGAL,
		IF_DIFFERENT,
		IF_SUP_EGAL,
		IF_SUP,
		IF_INF_EGAL,
		IF_INF,
		GOTO,
		RETURN,
		ENDLIFE,
		ANIM_REPEAT,
		ANIM_MOVE,
		TRACKMODE,
		HIT,
		MESSAGE,
		MESSAGE_VALUE,
		SET,
		INC,
		DEC,
		ADD,
		SUB,
		LIFE_MODE,
		SWITCH,
		CASE,
		CAMERA,
		START_CHRONO,
		MULTI_CASE,
		FOUND,
		LIFE,
		DELETE,
		TAKE,
		IN_HAND,
		READ,
		ANIM_SAMPLE,
		SPECIAL,
		DO_REAL_ZV,
		SOUND,
		FLAGS,
		GAME_OVER,
		MANUAL_ROT,
		RND_FREQ,
		MUSIC,
		SET_BETA,
		DO_ROT_ZV,
		CHANGEROOM,
		FOUND_NAME,
		FOUND_FLAG,
		FOUND_LIFE,
		CAMERA_TARGET,
		DROP,
		FIRE,
		TEST_COL,
		FOUND_BODY,
		SET_ALPHA,
		STOP_BETA,
		DO_MAX_ZV,
		PUT,
		C_VAR,
		DO_NORMAL_ZV,
		DO_CARRE_ZV,
		SAMPLE_THEN,
		LIGHT,
		SHAKING,
		ALLOW_INVENTORY,
		FOUND_WEIGHT,
		UP_COOR_Y,
		SPEED,
		PUT_AT,
		DEF_ZV,
		HIT_OBJECT,
		GET_HARD_CLIP,
		ANGLE,
		REP_SAMPLE,
		THROW,
		WATER,
		PICTURE,
		STOP_SAMPLE,
		NEXT_MUSIC,
		FADE_MUSIC,
		STOP_HIT_OBJECT,
		COPY_ANGLE,
		END_SEQUENCE,
		SAMPLE_THEN_REPEAT,
		WAIT_GAME_OVER,
		GET_MATRICE,
		STAGE_LIFE,
		CONTINUE_TRACK,
		ANIM_RESET,
		RESET_MOVE_MANUAL,
		PLUIE,
		ANIM_HYBRIDE_ONCE,
		ANIM_HYBRIDE_REPEAT,
		MODIF_C_VAR,
		CALL_INVENTORY, // 0x60
		BODY_RESET,
		DEL_INVENTORY,
		SET_INVENTORY,
		PLAY_SEQUENCE,
		_2D_ANIM_SAMPLE,
		SET_GROUND,
		PROTECT,
		DEF_ABS_ZV,
		DEF_SEQUENCE_SAMPLE,
		READ_ON_PICTURE,
		END = 0x10000,
		DEFAULT,
		ELSE
	}
}
