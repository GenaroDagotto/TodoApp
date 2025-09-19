# TodoApp ✅

This is my UI Framework project for the assignment.  
I built a simple **To-Do List app** using **Avalonia in C#**.

---

## 🎥 Loom Video
[Watch the demo here](https://www.loom.com/share/TU-VIDEO-ID)

---

## 🔗 GitHub Repository
[https://github.com/GenaroDagotto/TodoApp](https://github.com/GenaroDagotto/TodoApp)

---

## 📌 Features
- Add tasks using a text box and button
- Display tasks in a ListBox
- Remove selected tasks from the list
- Built with Avalonia for cross-platform support

---

## 🛠️ Debugging Note
At first, I tried to assign `Items` directly to the ListBox, but `Items` is read-only.  
I fixed this by using an **ObservableCollection<string>** and binding it to `ItemsSource`.  
This way, the ListBox updates automatically when items are added or removed.

