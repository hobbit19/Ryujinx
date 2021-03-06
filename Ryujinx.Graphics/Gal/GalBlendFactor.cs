namespace Ryujinx.Graphics.Gal
{
    public enum GalBlendFactor
    {
        Zero                  = 0x1,
        One                   = 0x2,
        SrcColor              = 0x3,
        OneMinusSrcColor      = 0x4,
        SrcAlpha              = 0x5,
        OneMinusSrcAlpha      = 0x6,
        DstAlpha              = 0x7,
        OneMinusDstAlpha      = 0x8,
        DstColor              = 0x9,
        OneMinusDstColor      = 0xa,
        SrcAlphaSaturate      = 0xb,
        Src1Color             = 0x10,
        OneMinusSrc1Color     = 0x11,
        Src1Alpha             = 0x12,
        OneMinusSrc1Alpha     = 0x13,
        ConstantColor         = 0x61,
        OneMinusConstantColor = 0x62,
        ConstantAlpha         = 0x63,
        OneMinusConstantAlpha = 0x64,

        ZeroGl                  = 0x4000,
        OneGl                   = 0x4001,
        SrcColorGl              = 0x4300,
        OneMinusSrcColorGl      = 0x4301,
        SrcAlphaGl              = 0x4302,
        OneMinusSrcAlphaGl      = 0x4303,
        DstAlphaGl              = 0x4304,
        OneMinusDstAlphaGl      = 0x4305,
        DstColorGl              = 0x4306,
        OneMinusDstColorGl      = 0x4307,
        SrcAlphaSaturateGl      = 0x4308,
        ConstantColorGl         = 0xc001,
        OneMinusConstantColorGl = 0xc002,
        ConstantAlphaGl         = 0xc003,
        OneMinusConstantAlphaGl = 0xc004,
        Src1ColorGl             = 0xc900,
        OneMinusSrc1ColorGl     = 0xc901,
        Src1AlphaGl             = 0xc902,
        OneMinusSrc1AlphaGl     = 0xc903
    }
}