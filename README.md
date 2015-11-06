# intelliSys.XPATH
An oversimplified XPath execution engine 

# Why?

I cannot believe there is no XPATH for HTML in Windows 8.1 RT. I build this simple XPATH execution engine, using LINQ of course.

The following is the test case:

    <language:OnlineSource SourceName="Bing Dictionary" RequestString="http://cn.bing.com/dict/?mkt=zh-CN" HeadlineSelectionPath="/html/body/div[3]/div/div[1]/div/div[2]/div[1]/div[1]/a" PhoneticSelectionPath="/html/body/div[3]/div/div[1]/div/div[2]/div[1]/div[2]/div[1]" SecondaryLineSelectionPath="/html/body/div[3]/div/div[1]/div/div[2]/div[1]/div[4]" Content="Word" Language="EnUs" TranslationLanguage="ZhCn"/>
            <language:OnlineSource SourceName="iCIBA英语学习" RequestString="http://news.iciba.com/dailysentence" HeadlineSelectionPath="//*[@id=&quot;content&quot;]/div[1]/div[1]/div[1]/div/div/p[1]" SecondaryLineSelectionPath="//*[@id=&quot;content&quot;]/div[1]/div[1]/div[1]/div/div/p[2]/a" Content="Sentence" Language="EnUs" TranslationLanguage="ZhCn"/>
            <language:OnlineSource SourceName="Merriam Webster" RequestString="http://www.merriam-webster.com/word-of-the-day/" HeadlineSelectionPath="/html/body/div[2]/div[1]/div[1]/div[2]/div/div[1]/div[2]/h1" SecondaryLineSelectionPath="/html/body/div[2]/div[1]/div[1]/div[2]/div/div[5]" Content="Word" Language="EnUs" TranslationLanguage="EnUs"/>
