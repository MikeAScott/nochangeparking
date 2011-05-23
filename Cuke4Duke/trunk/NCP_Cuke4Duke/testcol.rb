require 'rubygems'
require 'term/ansicolor'
include Term::ANSIColor
require 'ansicolor'

print bold, red, "red bold", reset, "\n"
print clear, red, "red regular", reset, "\n"