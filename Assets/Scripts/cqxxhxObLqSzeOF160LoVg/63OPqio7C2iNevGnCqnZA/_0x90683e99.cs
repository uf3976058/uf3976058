using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x90683e99 : MonoBehaviour
{
    private Color _0xddb20476 = Color.white;
    //public bool executeInUpdate;
    private float _0x17313b6b { get; set; }
    private float _0x33cae578 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xddb20476;
        Matrix4x4 _0x5eee8955 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x978594cc.orthographic)
        {
            float _0xcc23134d = this._0x978594cc.farClipPlane - this._0x978594cc.nearClipPlane;
            float _0x6f9db862 = (this._0x978594cc.farClipPlane + this._0x978594cc.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x6f9db862), new Vector3(this._0x978594cc.orthographicSize * 2 * this._0x978594cc.aspect, this._0x978594cc.orthographicSize * 2, _0xcc23134d));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x978594cc.fieldOfView, this._0x978594cc.farClipPlane, this._0x978594cc.nearClipPlane, this._0x978594cc.aspect);
        }

        Gizmos.matrix = _0x5eee8955;
    }

    private Vector3 _0xc68adc72 { get; set; }
    private Vector3 _0x843060ad { get; set; }
    private Vector3 _0xa6de7f5f { get; set; }
    private Vector3 _0x39797168 { get; set; }

    private void _0x26512ba6()
    {
        float _0xda8a8af9, _0x5b515f1c, _0x16b18976, _0x145cddca;
        if (this._0x9ecdd8f3 == _0x5ba868d9.Landscape)
            this._0x978594cc.orthographicSize = 1f / this._0x978594cc.aspect * this._0x666b6843 / 2f;
        else
            this._0x978594cc.orthographicSize = this._0x666b6843 / 2f;
        this._0x33cae578 = 2f * this._0x978594cc.orthographicSize;
        this._0x17313b6b = this._0x33cae578 * this._0x978594cc.aspect;
        float _0xb5f043f5 = this._0x978594cc.transform.position.x;
        float _0xaa3acd7c = this._0x978594cc.transform.position.y;
        _0xda8a8af9 = _0xb5f043f5 - this._0x17313b6b / 2;
        _0x5b515f1c = _0xb5f043f5 + this._0x17313b6b / 2;
        _0x16b18976 = _0xaa3acd7c + this._0x33cae578 / 2;
        _0x145cddca = _0xaa3acd7c - this._0x33cae578 / 2;
        this._0xd47fbb56 = new Vector3(_0xda8a8af9, _0x145cddca, 0);
        this._0x2263ea38 = new Vector3(_0xb5f043f5, _0x145cddca, 0);
        this._0x39797168 = new Vector3(_0x5b515f1c, _0x145cddca, 0);
        this._0x9002224b = new Vector3(_0xda8a8af9, _0xaa3acd7c, 0);
        this._0xa6de7f5f = new Vector3(_0xb5f043f5, _0xaa3acd7c, 0);
        this._0xc68adc72 = new Vector3(_0x5b515f1c, _0xaa3acd7c, 0);
        this._0x9d0d77b6 = new Vector3(_0xda8a8af9, _0x16b18976, 0);
        this._0x89045eda = new Vector3(_0xb5f043f5, _0x16b18976, 0);
        this._0x843060ad = new Vector3(_0x5b515f1c, _0x16b18976, 0);
    }

    private Vector3 _0x9d0d77b6 { get; set; }
    private Vector3 _0x89045eda { get; set; }

    private float _0x666b6843 = 1;
    private Vector3 _0x9002224b { get; set; }

    private _0x5ba868d9 _0x9ecdd8f3 = _0x5ba868d9.Portrait;
    public enum _0x5ba868d9
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x2263ea38 { get; set; }

    private static _0x90683e99 _0xce50fa3d;
    private void Awake()
    {
        this._0x978594cc = this.GetComponent<Camera>();
        _0xce50fa3d = this;
        this._0x26512ba6();
    }

    private new Camera _0x978594cc;
    private Vector3 _0xd47fbb56 { get; set; }
}