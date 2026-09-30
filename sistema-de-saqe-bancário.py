class saldonegativo(Exception):
    pass


class saldoinsuficiente(Exception):
    pass


print("Digite o valor do seu saldo atual.")
while True:
    try:
        saldo = float(input("- "))
        if saldo < 1:
            raise saldonegativo("O saldo não pode ser menor que 1.")
    except saldonegativo as erro:
        print(erro)
    except ValueError:
        print("Digite um número!")
    else:
        break
print("Digite quanto deseja sacar da sua conta.")
while True:
    try:
        saque = float(input("- "))
        if saque > saldo:
            raise saldoinsuficiente("Saldo insuficiente para essa transação.")
    except saldoinsuficiente as saldobaixo:
        print(saldobaixo)
    except ValueError:
        print("Digite um número!")
    else:
        print("Transação realizada com sucesso.")
        sobra = saldo - saque
        print(f"Sua conta agora possui R${sobra}.")
        break
    finally:
        print("Operação Bancária Finalizada")
        break
