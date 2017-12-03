namespace AdventOfCode1
{
    public class CaptchaSolver
    {
        public string SolveCatpcha(string captcha, bool isPt2)
        {
            var captchaArray = captcha.ToCharArray();
            int total = 0;
            for (var i = 0; i <= (captchaArray.Length - 1); i++)
            {
                var mod = 0;
                var zeroBaseLength = captchaArray.Length - 1;
                if (isPt2)
                {
                    mod = i + (captchaArray.Length / 2);
                    if (mod > zeroBaseLength)
                    {
                        mod = mod % captchaArray.Length;
                    }
                } 
                else
                {
                    mod = i == (captchaArray.Length - 1) ? 0 : i + 1;
                }
                
                if (captchaArray[mod] == captchaArray[i])
                {
                    total = total + int.Parse(captchaArray[i].ToString());
                }
            }
            return total.ToString();
        }
    }
}
