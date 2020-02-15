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
    // 弾オブジェクトの移動係数（速度調整用）
    void Start()
    {
        // 出現から３秒後に弾オブジェクトを消滅させる（メモリの節約）
        Destroy(gameObject, 3.0f);
    }
    void Update()
    {

    }

    public void Init(float angle, float speed)
    {
        // 弾オブジェクトの移動量ベクトルを作成（数値情報）
        Vector3 bulletMovement = new Vector3(Mathf.Cos(Mathf.Deg2Rad * angle) * speed, Mathf.Sin(Mathf.Deg2Rad * angle) * speed, 0);
        // Rigidbodyに移動量を加算する
        rb3d.AddForce(bulletMovement, ForceMode.VelocityChange);
    }

}