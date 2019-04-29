from jira import JIRA


jira_options = {'server': 'https://testbase.atlassian.net'}
jira = JIRA(options=jira_options, basic_auth=('mail.for.testbase@yandex.ru','12345678'))
#jira = JIRA('https://testbase.atlassian.net')

issue = jira.issue('TEST-1848') 
fOut = open('report.txt', 'w')
fOut.writelines(str(issue.fields.project.key)+'\n')             # 'JRA'
fOut.writelines(str(issue.fields.timeoriginalestimate)+'\n')          # 'New Feature'
fOut.writelines(str(issue.fields.status)+'\n')
fOut.writelines(str(issue.fields.timespent)+'\n')


