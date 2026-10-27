using UnityEngine;

/// <summary>Colour vocabulary of the app. Every value is a literal; nothing here reads
/// another static member, so declaration order can never matter.</summary>
public static class _0x5219e5ac
{
    public static readonly Color Deepest = new Color(0.039216f, 0.074510f, 0.149020f, 1f); // #0A1326
    public static readonly Color Surface = new Color(0.149020f, 0.227451f, 0.368627f, 1f); // #263A5E
    public static readonly Color Deep = new Color(0.090196f, 0.137255f, 0.235294f, 1f); // #17233C
    public static readonly Color Secondary = new Color(0.337255f, 0.800000f, 0.949020f, 1f); // #56CCF2
    public static readonly Color Accent = new Color(0.949020f, 0.788235f, 0.298039f, 1f); // #F2C94C
    public static readonly Color Shadow = new Color(0.019608f, 0.043137f, 0.094118f, 1f); // #050B18
    public static readonly Color Primary = new Color(0.184314f, 0.501961f, 0.929412f, 1f); // #2F80ED  fill only
    public static Color With(Color _0xcf210609, float _0x351df625)
    {
        return new Color(_0xcf210609.r, _0xcf210609.g, _0xcf210609.b, _0x351df625);
    }

    public static readonly Color TextPrimary = new Color(0.968627f, 0.980392f, 1f, 1f); // #F7FAFF
    public static readonly Color TextSecondary = new Color(0.658824f, 0.768627f, 0.917647f, 1f); // #A8C4EA
    public static readonly Color Raised = new Color(0.105882f, 0.168627f, 0.294118f, 1f); // #1B2B4B
}