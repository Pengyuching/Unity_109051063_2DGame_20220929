﻿using UnityEngine;

namespace Kaeru
{
    /// <summary>
    /// 玩家發射
    /// </summary>
    public class PlayerFireSystem : FireSystemBace
    {
        // 偵測玩家的輸入行為：鍵盤、滑鼠、觸控、搖桿
        private void Update()
        {
            // 如果 玩家 按下空白鍵 就生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}

