class SaldoInsuficiente(Exception):
    pass


print("Digite o saldo atual da sua conta.")
while True:
    try:
        saldo_atual = float(input("- "))
        break
    except ValueError:
        print("Digite apenas números!")

print("Digite quanto deseja sacar.")
while True:
    try:
        saque = float(input("- "))
        if saque <= 0:
            print("Digite um número maior que zero!")
            continue
        break
    except ValueError:
        print("Digite apenas números!")

print("Realizando operação...")
try:
    if saque > saldo_atual:
        raise SaldoInsuficiente("Saldo insuficiente para saque.")
    saldo_atual -= saque
    print(f"Saque realizado com sucesso! Saldo atual: R${saldo_atual:.2f}")
except SaldoInsuficiente as erro:
    print(f"Erro: {erro}")