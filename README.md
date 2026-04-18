# Лабораторная работа №29. 
#### REST API: контроллеры и маршруты
**ФИО:** Горбачева Маргарита
**Группа:** ИСП-231 
**Дата:** 18.04.2026
#### Краткое описание работы:
•	Изучены принципы архитектуры REST и API «RESTful»;
•	Создан первый контроллер с полным набором CRUD-маршрутов;
•	Освоена разницу между Minimal API и Controller-based API;
•	Проетирована API через Swagger UI и расширение REST Client в VS 
Code;
•	Освоины правильные HTTP-статусы и формат ответов.
#### Структура проекта (дерево файлов):
- 📁 img
- 📁 TaskApi
  -- 📁 Controllers
    - TaskController.cs

  -- 📁 Models
    - CreateTaskDto.cs
    - TaskItem.cs
    - UpdateTaskDto.cs

  -- 📁Properties
    - lauchSettings.json

  -- appsettings.Development.json
  -- appsettings.json
  -- Program.cs
  -- requests.http
  -- TaskApi.csproj
  -- TaskApi.http
  -- .editorconfig
  -- .gitingnore
  -- Lab29_RestAPI_Gorbacheva.sln
  -- README.md

#### Список всех реализованных маршрутов
| Метод | Маршрут |
| ----- | ------- |
GET|/api/tasks
GET|/api/tasks?completed={bool}
GET|/api/tasks/{id}
POST|/api/tasks
PUT|/api/tasks/{id}
PATCH|/api/tasks/{id}/complete
DELETE|/api/tasks/{id}
GET|/api/tasks/search?query={string}
GET|/api/tasks/priority/{level}
GET|/api/tasks/stats

#### Итоговая таблица ASP.NET Core Controller-based API

| Аспект | ASP.NET Core Controllers |
| ---- | -----|
Маршруты | [HttpGet] — атрибут над методом
Группировка маршрутов | класс‑контроллер
Базовый URL | [Route(“api/[controller]”)]
Параметр пути | (int id) — параметр метода
Параметр запроса | [FromQuery] bool? completed
Тело запроса | [FromBody] CreateTaskDto dto
Ответ 200 | return Ok(data)
Ответ 201 | return CreatedAtAction(…)
Ответ 404 | return NotFound()
Ответ 204 | return NoContent()
Типизация данных | строгая (C#)
Документация | Swagger — устанавливается отдельно

#### Главные выводы: 
```
1. REST - не жетский протокол, а набор принципов, которые обеспечивают единообразие, мастабируемость и простоту взаимодействия в веб-API
```

```
2. Поняли, что коды ответов (200, 201, 404, 500 и др.) — это «язык» общения сервера с клиентом, по ним фронтенд определяет успех операции, ошибку ввода или отсутствие ресурса.
```

```
3. Поняли, как атрибуты ([Route], [HttpGet] и т. д.) связывают URL и HTTP‑методы с методами контроллера, а также как порядок маршрутов влияет на их разрешение (например, /api/tasks/search имеет приоритет над /api/tasks/{id})
```

```
4. Поняли, почему опасно принимать от клиента полный объект модели: DTO позволяет ограничить входящие данные только теми полями, которые клиент вправе изменять (например, не передавать Id или CreatedAt).
```