Public Class MenuListClass
    Shared food_instance As MenuListClass = Nothing
    Private Sub New()
    End Sub
    Public Shared ReadOnly Property Instance() As MenuListClass
        Get
            If food_instance Is Nothing Then
                food_instance = New MenuListClass()
            End If
            Return food_instance
        End Get
    End Property
    Property foodList() As FoodClass()
        Get
            Return _foodList
        End Get
        Set(value As FoodClass())

        End Set
    End Property
    Private porridge1 As FoodClass = New FoodClass("小米粥", "碗", "主食", 5, 2)
    Private porridge2 As FoodClass = New FoodClass("皮蛋瘦肉粥", "碗", "主食", 8, 3)
    Private porridge3 As FoodClass = New FoodClass("黑米粥", "碗", "主食", 5, 2)
    Private porridge4 As FoodClass = New FoodClass("绿豆粥", "碗", "主食", 5, 2)
    Private huntun As FoodClass = New FoodClass("馄饨", "碗", "主食", 10, 8)
    Private bun1 As FoodClass = New FoodClass("猪肉包", "笼", "主食", 10, 5)
    Private bun2 As FoodClass = New FoodClass("牛肉包", "笼", "主食", 15, 5)
    Private bun3 As FoodClass = New FoodClass("素菜包", "笼", "主食", 8, 5)
    Private bun4 As FoodClass = New FoodClass("豆沙包", "笼", "主食", 6, 5)
    Private pastry1 As FoodClass = New FoodClass("葱油饼", "张", "主食", 7, 6)
    Private pastry2 As FoodClass = New FoodClass("糖饼", "个", "主食", 3.5, 3)
    Private pastry3 As FoodClass = New FoodClass("牛肉馅饼", "个", "主食", 8, 5)
    Private pastry4 As FoodClass = New FoodClass("猪肉馅饼", "个", "主食", 6, 5)
    Private pastry5 As FoodClass = New FoodClass("葱油饼", "张", "主食", 5, 6)
    Private dish1 As FoodClass = New FoodClass("凉拌菜", "盘", "菜品", 5, 2)
    Private dish2 As FoodClass = New FoodClass("白煮蛋", "个", "菜品", 1, 1)
    Private dish3 As FoodClass = New FoodClass("煎蛋", "个", "菜品", 2, 3)
    Private dish4 As FoodClass = New FoodClass("咸鸭蛋", "个", "菜品", 2, 1)
    Private drink1 As FoodClass = New FoodClass("热豆浆", "杯", "饮品", 2, 1)
    Private drink2 As FoodClass = New FoodClass("凉豆浆", "杯", "饮品", 2, 1)
    Private drink3 As FoodClass = New FoodClass("矿泉水", "瓶", "饮品", 2, 1)
    Private drink4 As FoodClass = New FoodClass("热牛奶", "杯", "饮品", 3, 1)
    Private drink5 As FoodClass = New FoodClass("凉豆浆", "杯", "饮品", 3, 1)
    Private _foodList() As FoodClass = {porridge1, porridge2, porridge3, porridge4, huntun, bun1, bun2, bun3, bun4, pastry1, pastry2, pastry3, pastry4, dish1, dish2, dish3, dish4, drink1, drink2, drink3, drink4, drink5}

End Class
