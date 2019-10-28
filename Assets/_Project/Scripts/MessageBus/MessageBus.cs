using System;

//using Terminus.Core.Configs;
using Bluehorse.Core.Helper;
using UnityEngine;
//using Terminus.Game.SaveLoad;


namespace Bluehorse.Game.Messages
{
	public sealed class MessageBus
	{
		//public static readonly Message<QuestState, QuestState> QuestReplaced = new Message<QuestState, QuestState>();

		//public static readonly Message<int> OnBubbleDestroy = new Message<int>();
		//public static readonly Message<int> OnBubbleColorMatch = new Message<int>();

		//public static readonly Message<Fish, ColorType, Vector3> OnFishSpawned = new Message<Fish, ColorType, Vector3>();
		//public static readonly Message<Fish, ColorType, Vector3> OnFishDead = new Message<Fish, ColorType, Vector3>();
		//public static readonly Message OnFishDying = new Message();

		//public static readonly Message<Fish, ColorType, Vector3> OnFishRescued = new Message<Fish, ColorType, Vector3>();
		//public static readonly Message<Fish, ColorType, Vector3> OnFishFinishedSmiling = new Message<Fish, ColorType, Vector3>();

		//public static readonly Message<int> OnFoodDestroy = new Message<int>();

		//public static readonly Message OnGameInit = new Message();
		//public static readonly Message OnGameStart = new Message();
		//public static readonly Message<bool> OnGamePause = new Message<bool>();
		//public static readonly Message<bool> OnGameStop = new Message<bool>();

		//public static readonly Message<string> OnLevelSelected = new Message<string>();
		//public static readonly Message<string> OnLevelBuilt = new Message<string>();
		//public static readonly Message<Level> OnLevelComplete = new Message<Level>();
		//public static readonly Message<Level> OnLevelFailed = new Message<Level>();

		//public static readonly Message OnPlayerLivesOut = new Message();

		//public static readonly Message OnGameProgressReset = new Message();
		//public static readonly Message<float> OnLocationPaint = new Message<float>();
	}

	//public sealed class PvpBattleSurrenderMessageArgs
	//    : MessageArgs
	//{
	//    public PvpBattleSurrenderMessageArgs(string opponentId)
	//    {
	//        OpponentId = opponentId;
	//    }

	//    public string OpponentId { get; }
	//}

	//public sealed class PveBattleSurrenderMessageArgs
	//    : MessageArgs
	//{
	//    public PveBattleSurrenderMessageArgs(string missionId, MissionDifficulty missionDifficulty)
	//    {
	//        MissionId = missionId;
	//        MissionDifficulty = missionDifficulty;
	//    }

	//    public string MissionId { get; }
	//    public MissionDifficulty MissionDifficulty { get; }
	//}

	public class MessageArgs
	{
		public static readonly MessageArgs None = new MessageArgs();

		public override string ToString()
		{
			return "()";
		}
	}
}