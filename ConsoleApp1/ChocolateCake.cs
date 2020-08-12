public class ChocolateCake : SpongeCake
{

    public override string getName()
    { // 親クラスの名前を得るメソッドをオーバーライド
        return "チョコレートケーキ";
    }

    public override int getPrice()
    { // 親クラスの価格を得るメソッドをオーバーライド
        return 700;
    }

}
