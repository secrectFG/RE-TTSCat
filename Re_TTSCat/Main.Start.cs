﻿using System;
using System.Windows.Forms;
using BilibiliDM_PluginFramework;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        public override async void Start()
        {
            Log("插件启动中");
            try
            {
                Log("正在启用数据桥");
                RunBridge();
                Log("正在初始化配置");
                await Data.Conf.InitiateAsync();
                Log("配置初始化成功");
                Log("正在启用播放器");
                TTSPlayer.Init();
                if (Data.Vars.CurrentConf.AutoUpdate)
                {
                    Log("正在检查更新");
                    try
                    {
                        var latestVersion = await KruinUpdates.Update.GetLatestUpdAsync();
                        var currentVersion = Data.Vars.currentVersion;
                        if (KruinUpdates.CheckIfLatest(latestVersion, currentVersion))
                        {
                            Log("插件已为最新 (" + Data.Vars.currentVersion.ToString() + ")");
                        }
                        else
                        {
                            Log("发现更新: " + latestVersion.LatestVersion.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Log("检查更新出错: " + ex.Message);
                    }
                    
                }
                Log("启动成功");
                base.Start();
            }
            catch (Exception ex)
            {
                Log("启动过程中出错: " + ex.ToString());
                Windows.AsyncDialog.Open("启动失败，更多信息请查看日志。\n\n如您在后期继续使用时遇到问题，请尝试重新启动弹幕姬。", "Re: TTSCat", MessageBoxIcon.Error);
                Log("启动失败");
            }
        }
    }
}