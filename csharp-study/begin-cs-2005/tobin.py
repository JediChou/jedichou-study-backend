#!/usr/bin/env python

import os

def checkPathVariable():
    '''
        1. Get enviorment variables.
        2. Compare with expected enviorment variables.
        3. Return compared result.
        Notice: Only for jedi
    '''
    result = True
    curlst = os.environ.get('path').split(';')
    explst = [
        'D:\\ProgramTools\\VSTS2010\\VSTSDB\\Deploy',
        'D:\\ProgramTools\\VSTS2010\\Common7\\IDE\\',
        'D:\\ProgramTools\\VSTS2010\\VC\\BIN',
        'D:\\ProgramTools\\VSTS2010\\Common7\\Tools',
        'C:\\WINDOWS\\Microsoft.NET\\Framework\\v4.0.30319',
        'D:\\ProgramTools\\VSTS2010\\VC\\VCPackages',
        'C:\\Program Files\\Microsoft SDKs\\Windows\\v7.0A\\bin\\NETFX 4.0 Tools',
        'C:\\Program Files\\Microsoft SDKs\\Windows\\v7.0A\\bin',
        'C:\\WINDOWS\\system32',
        'C:\\WINDOWS'
        ] 
    
    for itemexp in explst:
        result = result & ( itemexp in curlst )

    return result
    
def getCurrentFilelist():
    '''
        1. Get a list of current directory.
        2. Drop tobin.py. It will not included file list.
    '''
    filelist = os.listdir(os.getcwd())

    if 'tobin.py' in filelist:
        filelist.remove('tobin.py')
    if 'tobin.dll' in filelist:
        filelist.remove('tobin.dll')
    if 'tobin.exe' in filelist:
        filelist.remove('tobin.exe')
    if 'bin.exe' in filelist:
        filelist.remove('bin.exe')
        
    return filelist

def getLastModifyFile(filelist):
    '''
        1. Make a dict that consist file name and modify time.
        2. Fill dict from filelist parameter.
        3. Find and return the lasted file's name.
    '''
    filelistStat = {}
    filelistMody = []
    maxtime = 0.0000000

    for file in filelist:
        filelistStat[os.stat(file).st_mtime] = file
    filelistMody = filelistStat.keys()

    for time in filelistMody:
        if maxtime < time:
            maxtime = time

    return  filelistStat.get(maxtime)

if __name__ == '__main__':
    '''
        File name   : tobin.py
        Description : Get lasted file and compile.
        Version     : 0.0.1 - 2013/8/1
        Author      : Jedi Chou
        Execution   :
          python tobin.py [no parameter] # use python 2.6 or 2.7
          ipy tobin.py [no parameter]    # use IronPython
        Step design :
          1. Initial enviorment
          2. Get target file
          3. Complie, return compile message
    '''
    
    '''
	# 1. Initial environment
	if checkPathVariable():
        pass
    else:
        print "Complier env variables is wrong."
        exit() # debug
	'''
        
    # 2. Get target file
    target = getLastModifyFile(getCurrentFilelist())
        
    # 3. Compile, return compile message
    try:
        os.system('csc.exe /out:bin.exe ' + target)
    except Exception, e:
        print "Compile failed - Please check source or script"
        print type(e), e
