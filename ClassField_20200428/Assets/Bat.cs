using UnityEngine;
using System;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    #region 設定基礎數值
    [Header("血量"), Tooltip("蝙蝠血量")]
    [Range(20, 50)]
    public int 血量 = 50;

    [Header("攻擊力"), Tooltip("蝙蝠攻擊力")]
    [Range(5, 10)]
    public int 攻擊力 = 10;

    [Header("治癒量"), Tooltip("蝙蝠治癒量")]
    [Range(5, 10)]
    public int 治癒量 = 5;
    #endregion


    [Header("文字：輸出的結果")]
    public Text result;

    public Slime slime1;

    /// <summary>
    /// 蝙蝠的攻擊
    /// </summary>
    public void Attack()
    {
        result.text = slime1.name + "受到了" + 攻擊力 + "的傷害";
        slime1.Hurt();
    }

    /// <summary>
    /// 蝙蝠受到的傷害
    /// </summary>
    public void Hurt()
    {
        int 總血量 = 血量 -= slime1.攻擊力;
        result.text +=  "\n" + gameObject.name + "目前血量：" + 總血量;
    }

    /// <summary>
    /// 蝙蝠回血
    /// </summary>
    public void Heal()
    {
        result.text = gameObject.name + "回復了" + 治癒量 + "的血量" + "\n"
                     + gameObject.name + "目前血量：" + (血量 += 治癒量);
    }

}
