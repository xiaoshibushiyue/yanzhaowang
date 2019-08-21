from selenium import webdriver
import time

driver=webdriver.Chrome()
driver.get("https://yz.chsi.com.cn/zsml/querySchAction.do?ssdm=11&dwmc=北京大学&mldm=zyxw&mlmc=&yjxkdm=0552&xxfs=&zymc=新闻与传播")
print(driver.page_source)
driver.close()
