using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shot : MonoBehaviour
{
    // 弾オブジェクト（Inspectorでオブジェクトを指定）
    [SerializeField] // Inspectorで操作できるように属性を追加します
    private GameObject bullet;
    public Vector3 localGravity;
    // 弾オブジェクトのRigidbody2Dの入れ物
    public Rigidbody rb3d;
    Renderer targetRenderer;

    int removeTimer = 0;

    bool inGamefield = true;

    public int removeTime = 120;
    // 弾オブジェクトの移動係数（速度調整用）
    void Start()
    {
        // 出現から３秒後に弾オブジェクトを消滅させる（メモリの節約）
        targetRenderer = GetComponent<Renderer>();
    }
    void Update()
    {
        if (inGamefield)
        {
            // 画面内に表示されている場合の処理
            removeTimer = 0;
        }
        else
        {
            // 画面内に表示されていない場合の処理
            removeTimer++;
        }
        //一定時間画面外にいると消滅する
        if (removeTimer >= removeTime)
        {
            Destroy(gameObject);
        }
    }

    void OnBecameVisible()
    {
        // 表示されるようになった時の処理
        inGamefield = true;
        removeTimer = 0;
    }
    void OnBecameInvisible()
    {
        // 表示されなくなった時の処理
        inGamefield = false;
    }
    public void Init(float angle, float speed)
    {
        // 弾オブジェクトの移動量ベクトルを作成（数値情報）
        Vector3 bulletMovement = new Vector3(Mathf.Cos(Mathf.Deg2Rad * angle) * speed, Mathf.Sin(Mathf.Deg2Rad * angle) * speed, 0);
        // Rigidbodyに移動量を加算する
        rb3d.AddForce(bulletMovement, ForceMode.VelocityChange);
    }

}