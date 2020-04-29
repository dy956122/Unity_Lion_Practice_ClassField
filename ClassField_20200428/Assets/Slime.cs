 using UnityEngine;
using System;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    #region 設定基礎數值
    [Header("血量"), Tooltip("史萊姆血量")]
    [Range(20,60)]
    public int 血量 = 60;

    [Header("攻擊力"), Tooltip("史萊姆攻擊力")]
    [Range(5,10)]
    public int 攻擊力 = 5;
    
    [Header("治癒量"), Tooltip("史萊姆治癒量")]
    [Range(5,10)]
    public int 治癒量 = 10;
    #endregion

    [Header("文字：輸出的結果")]
    public Text result;

    public Bat bat1;

    /// <summary>
    /// 史萊姆的攻擊
    /// </summary>
    public void Attack()
    {
        result.text = bat1.name + "受到了" + 攻擊力 + "的傷害";
        bat1.Hurt();
    }

    /// <summary>
    /// 史萊姆受到的傷害
    /// </summary>
    public void Hurt()
    {
        int 總血量 = 血量 -= bat1.攻擊力;
        result.text += "\n" +  gameObject.name + "目前血量：" + 總血量;
    }

    /// <summary>
    /// 史萊姆回血
    /// </summary>
    public void Heal()
    {
        result.text = gameObject.name + "回復了" + 治癒量 + "的血量" + "\n"
              + gameObject.name + "目前血量：" + (血量 += 治癒量);
    }
}
