namespace AdventOfCode1
{
    public class CaptchaSolver
    {
        public string SolveCatpcha(string captcha)
        {
            var captchaArray = captcha.ToCharArray();
            int total = 0;
            for (var i = 0; i <= (captchaArray.Length - 1); i++)
            {
                var mod = i == (captchaArray.Length - 1) ? 0 : i + 1;
                if (captchaArray[mod] == captchaArray[i])
                {
                    total = total + int.Parse(captchaArray[i].ToString());
                }
            }
            return total.ToString();
        }
    }
}
