TARGET=terminal_fun
INCLUDE=../include
BIN=../binary
FLAG=-g -std=c++11 -O2 -DMAKE
GXX=g++

TERMINAL_FUN_OBJS=terminal.o terminal_fun.o main.o

.PHONY: clean

all: $(TARGET)

%.o: %.cpp
	@echo "making: " $@
	@$(GXX) $< -c $(FLAG) -I$(INCLUDE)

clean:
	rm -rf *.o
	@for binary in $(TARGET); do \
		echo "rm -rf $(BIN)/$$binary"; \
		rm -rf $(BIN)/$$binary; \
	done

terminal_fun: $(TERMINAL_FUN_OBJS)
	@echo "making: " $@
	@$(GXX) -o $(BIN)/$@ $(FLAG) -I$(INCLUDE) $(TERMINAL_FUN_OBJS)
