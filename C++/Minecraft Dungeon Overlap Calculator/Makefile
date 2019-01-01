.PHONY:clean

# Compiler & options
CC=g++
CFLAGS=-std=c++11 -O2
DEBUG=-g -DDEBUG
WARN=-Wall

# File directory
BIN_DIR=bin
OBJ_DIR=obj
SRC_DIR=src
INC_DIR=include

# Files
_BIN=Minecraft\ Dungeon\ Overlap\ Calculator
_OBJ=
_INCLUDE=

# Directed Files
BIN=$(patsubst %, $(BIN_DIR)/%, %(_BIN))
OBJ=$(patsubst %, $(OBJ_DIR)/%, $(_OBJ))
INCLUDE=$(patsubst %, $(INC_DIR)/%, $(_INCLUDE))

# Default make
default:main

# Make all
main: $(OBJS)
	$(CC) $(CFLAGS) -o $@ $^

# Objective file dependency
$(OBJ_DIR)/%.o: $(SRC_DIR)/%.c $(INCLUDE)
	$(CC) $(CFLAGS) -c -o $@ $<

# Clean middle files
clean:
	rm -f $(OBJ_DIR)/*
	rm -f $(BIN_DIR)/*
