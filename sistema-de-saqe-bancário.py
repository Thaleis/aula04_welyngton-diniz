class  saldoinsuficiente(Exception):
    pass


print("Digite o saldo atual da sua conta.")
while True:
    try:
        try:
            saldo_atual= float(input("- "))
            break
        except ValueError:
            print("Digite apenas números!")
    print("Digite quanto deseja sacar.")
    while True:
        try:
            saque = float(input("- "))
            break
            if saque <= 0:
                print("Digite um número maior que zero!")
        except ValueError:
            print("Digite apenas números! ")     
    print("Realizando operação...")
    if saque > saldo_atual:
        raise saldoinsuficiente("Saldo insuficiente para saque.")
    except saldoinsuficiente as erro
 
