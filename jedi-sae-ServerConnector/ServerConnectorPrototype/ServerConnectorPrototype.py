#!c:/python27/bin/python.exe
# -*- coding: utf-8 -*-

import os

# v = ['192.168.100.%d' % (x) for x in range(1, 6)]
ret = os.system('ping 114.foxconn.com')
print ret