CC=mcs
CSFLAGS=-out
FILE = implementationproject

all: make

make: $(FILE).cs Makefile
	$(CC) $(CSFLAGS):$(FILE).exe $(FILE).cs

../src.zip: file.c Makefile test.sh
	cd .. && zip src.zip src/file.c src/Makefile src/test.sh

clean:
	rm -f *.exe

.PHONY: clean
