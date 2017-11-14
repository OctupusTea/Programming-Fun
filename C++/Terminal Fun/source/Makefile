TARGET=terminal_fun
INCLUDE=-I../include
BIN=../bin
FLAG=-g -std=c++11 -O2 -DMAKE
GCC=g++

TERMINAL_FUN_OBJS=terminal_fun.o main.o

.PHONY: clean

all: $(TARGET)

%.o: %.cpp
	@echo "making: " $@
	@$(GCC) $< -c $(FLAG) $(INCLUDE)

clean:
	rm -rf *.o
	@for bin in $(TARGET); do \
		echo "rm -rf $(BIN)/$$bin"; \
		rm -rf $(BIN)/$$bin; \
	done

terminal_fun: $(TERMINAL_FUN_OBJS)
	@echo "making: " $@
	@$(GCC) -o $(BIN)/$@ $(FLAG) $(INCLUDE) $(TERMINAL_FUN_OBJS)
