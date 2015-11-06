# intelliSys.XPATH
An oversimplified XPath execution engine 

# Why?

I cannot believe there is no XPATH for HTML in Windows 8.1 RT. 

I build this simple XPATH execution engine, using LINQ of course.
This does (of course) not conform to the full XPATH standard, and may tolerate more or less syntax error. The algorithm is fairly simple - just keep track of the leaf nodes of the evaluation tree and flatten the tree whenever childnodes are accessed.

This works with `HtmlAgility` pack, as we need their `HtmlNode` to operate on. Use

    public static IEnumerable<HtmlNode> SelectMultipleNodes(this HtmlNode node, string xpath)

for multiple node Xpath, otherwise, use

    public static HtmlNode INSSSelectSingleNode(this HtmlNode node, string xpath)
    
for single node XPath.

# REALLY, WHY?

Fine I need to use XPATH in LockView but I cannot find any!

The following is the test case.

    <language:OnlineSource RequestString="http://cn.bing.com/dict/?mkt=zh-CN" HeadlineSelectionPath="/html/body/div[3]/div/div[1]/div/div[2]/div[1]/div[1]/a" PhoneticSelectionPath="/html/body/div[3]/div/div[1]/div/div[2]/div[1]/div[2]/div[1]" SecondaryLineSelectionPath="/html/body/div[3]/div/div[1]/div/div[2]/div[1]/div[4]"/>
    <language:OnlineSource RequestString="http://news.iciba.com/dailysentence" HeadlineSelectionPath="//*[@id=&quot;content&quot;]/div[1]/div[1]/div[1]/div/div/p[1]" SecondaryLineSelectionPath="//*[@id=&quot;content&quot;]/div[1]/div[1]/div[1]/div/div/p[2]/a" />
    <language:OnlineSource RequestString="http://www.merriam-webster.com/word-of-the-day/" HeadlineSelectionPath="/html/body/div[2]/div[1]/div[1]/div[2]/div/div[1]/div[2]/h1" SecondaryLineSelectionPath="/html/body/div[2]/div[1]/div[1]/div[2]/div/div[5]"/>
