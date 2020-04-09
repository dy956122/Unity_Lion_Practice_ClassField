using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物的血量
    /// </summary>
    [Header("血量"), Tooltip("怪物的血量")]
    [Range(50, 100)]
    public int 血量; // 想要把這邊全部的int,都用short取代

    /// <summary>
    /// 怪物的魔力
    /// </summary>
    [Header("魔力"), Tooltip("怪物的魔力")]
    [Range(10 ,100)]
    public int 魔力 = 100;

    /// <summary>
    /// 怪物的能力值
    /// </summary>
    [Header("能力值")]
    [Range(1.0f ,50.5f)]
    public float 移動速度 = 10.5f ;

    /// <summary>
    /// 怪物的攻擊力
    /// </summary>
    [Range(20 ,200)]
    public int 攻擊力 = 50 ;

    /// <summary>
    /// 怪物的防禦力
    /// </summary>
    [Range(0 ,100)]
    public int 防禦力 ;

    /// <summary>
    /// 怪物的武器
    /// </summary>
    [Header("裝備")]
    public string 武器名稱;

    /// <summary>
    /// 怪物的裝備
    /// </summary>
    public string 裝備名稱 = "皮衣" ;

    /// <summary>
    /// 怪物是否帶有鑰匙
    /// </summary>
    [Header("其他資料"), Tooltip("怪物是否帶有鑰匙")]
    public bool 是否帶有鑰匙 = false ;

    /// <summary>
    /// 怪物是否帶有寶物
    /// </summary>
    [Tooltip("怪物是否帶有寶物")]
    public bool 是否掉落寶物 = false;
}

