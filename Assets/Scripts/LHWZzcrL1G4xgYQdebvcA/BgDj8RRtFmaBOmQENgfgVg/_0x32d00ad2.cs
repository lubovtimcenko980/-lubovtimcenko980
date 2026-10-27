using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x32d00ad2 : MonoBehaviour
{
    private float _0x044954df = 1;
    private Vector3 _0x8185e814 { get; set; }
    private Vector3 _0xf211b23a { get; set; }

    private static _0x32d00ad2 _0x59e21e9e;
    private Vector3 _0x754d6b7b { get; set; }

    public enum _0x6fc151be
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xe5098eef { get; set; }
    private Vector3 _0x4fdfc4ca { get; set; }
    private Vector3 _0xa6efa4ba { get; set; }

    private Color _0x2af75617 = Color.white;
    private void Awake()
    {
        this._0x51257652 = this.GetComponent<Camera>();
        _0x59e21e9e = this;
        this._0x7f17bd0a();
    }

    private Vector3 _0x619a9869 { get; set; }
    private Vector3 _0xf5eed1ed { get; set; }
    //public bool executeInUpdate;
    private float _0xe75271bc { get; set; }

    private void _0x7f17bd0a()
    {
        float _0xb90270c4, _0x5c646678, _0xdfc4f834, _0x1bfe19ad;
        if (this._0xa3713d3f == _0x6fc151be.Landscape)
            this._0x51257652.orthographicSize = 1f / this._0x51257652.aspect * this._0x044954df / 2f;
        else
            this._0x51257652.orthographicSize = this._0x044954df / 2f;
        this._0x322e44e0 = 2f * this._0x51257652.orthographicSize;
        this._0xe75271bc = this._0x322e44e0 * this._0x51257652.aspect;
        float _0xfc051298 = this._0x51257652.transform.position.x;
        float _0x7121afea = this._0x51257652.transform.position.y;
        _0xb90270c4 = _0xfc051298 - this._0xe75271bc / 2;
        _0x5c646678 = _0xfc051298 + this._0xe75271bc / 2;
        _0xdfc4f834 = _0x7121afea + this._0x322e44e0 / 2;
        _0x1bfe19ad = _0x7121afea - this._0x322e44e0 / 2;
        this._0x619a9869 = new Vector3(_0xb90270c4, _0x1bfe19ad, 0);
        this._0xf211b23a = new Vector3(_0xfc051298, _0x1bfe19ad, 0);
        this._0xd91d9ccd = new Vector3(_0x5c646678, _0x1bfe19ad, 0);
        this._0x754d6b7b = new Vector3(_0xb90270c4, _0x7121afea, 0);
        this._0xe5098eef = new Vector3(_0xfc051298, _0x7121afea, 0);
        this._0xa6efa4ba = new Vector3(_0x5c646678, _0x7121afea, 0);
        this._0x8185e814 = new Vector3(_0xb90270c4, _0xdfc4f834, 0);
        this._0xf5eed1ed = new Vector3(_0xfc051298, _0xdfc4f834, 0);
        this._0x4fdfc4ca = new Vector3(_0x5c646678, _0xdfc4f834, 0);
    }

    private new Camera _0x51257652;
    private _0x6fc151be _0xa3713d3f = _0x6fc151be.Portrait;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x2af75617;
        Matrix4x4 _0x21cc386c = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x51257652.orthographic)
        {
            float _0x36e147a6 = this._0x51257652.farClipPlane - this._0x51257652.nearClipPlane;
            float _0xfabe379a = (this._0x51257652.farClipPlane + this._0x51257652.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xfabe379a), new Vector3(this._0x51257652.orthographicSize * 2 * this._0x51257652.aspect, this._0x51257652.orthographicSize * 2, _0x36e147a6));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x51257652.fieldOfView, this._0x51257652.farClipPlane, this._0x51257652.nearClipPlane, this._0x51257652.aspect);
        }

        Gizmos.matrix = _0x21cc386c;
    }

    private Vector3 _0xd91d9ccd { get; set; }
    private float _0x322e44e0 { get; set; }
}