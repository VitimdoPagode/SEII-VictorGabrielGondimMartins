#!/bin/bash


case ${1,,} in
	victor | admin)
		echo "Oi, voce eh o dono mesmo!"
		;;
	help)
		echo "Entre com o nome"
		;;
	*)
		echo "Voce nao eh o dono, entre com o nome para que possa ser verificado!"
esac
