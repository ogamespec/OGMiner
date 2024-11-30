# https://stackoverflow.com/questions/5953373/how-to-split-image-into-multiple-pieces-in-python

import os
import sys
from PIL import Image

def CropImage (src, dest, rect):
	im = Image.open(src + ".png")
	a = im.crop([rect[0], rect[1], rect[0]+rect[2], rect[1]+rect[3]])
	a.save("%s.png" % dest)

if __name__ == '__main__':
	print ("staff_splitter Start")
	FusedImg = "staff"
	ofs = [ 0, 45, 90, 135, 180 ]
	officers = [ "admiral", "commander", "engineer", "geologist", "technocrate" ]
	rn = 0
	for r in officers:
		CropImage (FusedImg, r + "_off", [ofs[rn], 0, 32, 32] )
		CropImage (FusedImg, r + "_on", [ofs[rn], 45, 32, 32] )
		rn += 1
	print ("staff_splitter End")
