import instaloader


# Script allow you to download picture profile instagram using libruary instaloader 
try:
    test = instaloader.Instaloader()
    c = ['yes','y','Yes','YES']
    while True  :
        acc = input('enter the account username: ')
        test.download_profile(acc,profile_pic_only = True)
        if input('do you want to continue? Y/N: ') not in c:
            print('okey good bye !!','tab enter to exit',sep="\n")
            break
        else :
            continue

except : 
    print('Somethings wrong !!!!')
