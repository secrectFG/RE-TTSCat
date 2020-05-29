﻿using System.Collections.Generic;

namespace Re_TTSCat.Data
{
    public partial class Conf
    {
        public Conf()
        {
            AutoUpdate = true;
            BlackList = "";
            WhiteList = "";
            BlockMode = 0;
            GiftBlockMode = 0;
            KeywordBlockMode = 0;
            BlockUID = true;
            DebugMode = false;
            DownloadFailRetryCount = 5;
            DoNotKeepCache = false;
            Engine = 0;
            GiftBlackList = "";
            GiftWhiteList = "";
            KeywordBlackList = "";
            KeywordWhiteList = "";
            MinimumDanmakuLength = 3;
            MaximumDanmakuLength = 50;
            ReadInQueue = true;
            ReadPossibility = 100;
            TTSVolume = 100;
            ReadSpeed = 0;
            UseGoogleGlobal = false;
            AllowDownloadMessage = true;
            AllowConnectEvents = true;
            ClearQueueAfterDisconnect = true;
            CatchGlobalError = true;
            SuperChatIgnoreRandomDitch = true;
            SaveCacheInTempDir = true;
            SuppressLogOutput = false;
            ClearCacheOnStartup = true;
            OverrideToLogsTabOnStartup = false;
            AutoStartOnLoad = false;
            SpeechPerson = 0;
            EnableVoiceReply = false;
            InstantVoiceReply = false;
            MinifyJson = true;
            HttpAuth = false;
            HttpAuthPassword = "";
            HttpAuthUsername = "";
            Headers = new List<Header>();
            ReqType = RequestType.JustGet;
            PostData = "";

            CustomEngineURL = "https://tts.example.com/?text=$TTSTEXT";
            OnConnected = "已成功连接至房间: $ROOM";
            OnDisconnected = "已断开连接: $ERROR";
            OnDanmaku = "$USER 说: $DM";
            OnSuperChat = "$USER 发送了醒目留言: $DM";
            OnGift = "收到来自 $USER 的 $COUNT 个 $GIFT";
            OnGuardBuy = "$USER 上船了 $COUNT 月";
            OnLiveStart = "直播已开始";
            OnLiveEnd = "直播已结束";
            OnWelcome = "欢迎老爷: $USER";
            OnWelcomeGuard = "欢迎船员: $USER";
            CustomVIP = "老爷";
            CustomGuardLevel0 = "用户";
            CustomGuardLevel1 = "总督";
            CustomGuardLevel2 = "提督";
            CustomGuardLevel3 = "舰长";
            VoiceReplyRules = new List<VoiceReplyRule>();
        }
    }
}
