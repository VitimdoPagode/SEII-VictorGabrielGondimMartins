#!/bin/bash

up="before"
since="function"
echo $up
echo $since

showuptime(){
	local up=$(uptime -p | cut -c4-)
	local since=$(uptime -s)
	cat << EOF
-------
ESSA MAQUINA ESTA LIGADA A ${up}
E ESTA LIGADA DESDE  ${since}
------
EOF
}
showuptime
