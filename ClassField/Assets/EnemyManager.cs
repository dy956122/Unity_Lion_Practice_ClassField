using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [Header("怪物一號")]
    public Enemy 怪物一號;

    [Header("怪物二號")]
    public Enemy 怪物二號;

    void Start()
    {
        print("怪物一號的魔力:" + 怪物一號.血量);
        print("怪物二號的裝備名稱:" + 怪物二號.裝備名稱) ;

        怪物一號.血量 = 100 ;
        怪物二號.血量 = 300 ;

        怪物一號.防禦力 = 50;

        怪物一號.武器名稱 = "木棍" ;
        怪物二號.武器名稱 = "短刀" ;

        怪物一號.是否帶有鑰匙 = true ;
        怪物二號.是否掉落寶物 = true ;
    }

}
